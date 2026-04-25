using StackOnLinckedListVisualizer.Interfaces;
using StackOnLinckedListVisualizer.Models;
using System.Text;

namespace StackOnLinckedListVisualizer.Implementations;

public class StackOnLinkedListAlgorithm : IExecutableAlgorithm
{
    private const string SOURCE = "StackOnLinkedListAlgorithm";

    public object Execute(AlgorithmSettings settings)
    {
        LogManager.Log(LogLevel.INFO, "Starting stack algorithm execution");
        if (settings == null)
        {
            LogManager.Log(LogLevel.ERROR, "Settings object is null");
            throw new ArgumentNullException(nameof(settings), "Settings cannot be null");
        }

        if (!(settings is StackOnLinkedListSettings stackSettings))
        {
            LogManager.Log(LogLevel.ERROR, "Invalid settings type");
            throw new InvalidOperationException("Expected StackOnLinkedListSettings");
        }

        LogManager.Log(LogLevel.INFO, $"Executing with collection size: {stackSettings.CollectionSize}");

        var result = new StackOperationResult();
        result.CurrentStackState = stackSettings.DataCollection.ToList();
        result.CurrentSize = stackSettings.DataCollection.Count;
        result.Success = true;
        result.Message = "Stack state retrieved successfully";

        LogManager.Log(LogLevel.INFO, $"Stack contains {result.CurrentSize} elements");

        return result;

    }

    public object LoadResults(string filePath)
    {
        LogManager.Log(LogLevel.INFO, $"Loading results from {filePath}");

        try
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"File not found: {filePath}");
            }

            var result = new StackOperationResult();
            var lines = File.ReadAllLines(filePath, Encoding.UTF8);

            foreach (var line in lines)
            {
                if (line.StartsWith("Success:"))
                {
                    result.Success = bool.Parse(line.Substring(8).Trim());
                }
                else if (line.StartsWith("Message:"))
                {
                    result.Message = line.Substring(8).Trim();
                }
                else if (line.StartsWith("CurrentSize:"))
                {
                    result.CurrentSize = int.Parse(line.Substring(12).Trim());
                }
                else if (line.StartsWith("PoppedValue:"))
                {
                    var val = line.Substring(12).Trim();
                    if (val != "null")
                        result.PoppedValue = int.Parse(val);
                }
                else if (line.StartsWith("PeekedValue:"))
                {
                    var val = line.Substring(12).Trim();
                    if (val != "null")
                        result.PeekedValue = int.Parse(val);
                }
                else if (line.StartsWith("StackState:"))
                {
                    var stateStr = line.Substring(11).Trim();
                    if (!string.IsNullOrEmpty(stateStr))
                    {
                        result.CurrentStackState = stateStr.Split(',')
                            .Where(s => !string.IsNullOrEmpty(s))
                            .Select(int.Parse)
                            .ToList();
                    }
                }
            }

            LogManager.Log(LogLevel.INFO, $"Results loaded successfully from {filePath}");
            return result;
        }
        catch (Exception ex)
        {
            LogManager.Log(LogLevel.ERROR, $"Failed to load results: {ex.Message}");
            throw;
        }
    }

    public void SaveResults(string filePath, object results)
    {
        LogManager.Log(LogLevel.INFO, $"Saving results to {filePath}");

        try
        {
            if (results == null)
            {
                throw new ArgumentNullException(nameof(results), "Results cannot be null");
            }

            if (!(results is StackOperationResult stackResult))
            {
                throw new InvalidOperationException("Invalid results type");
            }

            using (var writer = new StreamWriter(filePath, false, Encoding.UTF8))
            {
                writer.WriteLine("# Stack on Linked List - Results");
                writer.WriteLine($"# Saved: {DateTime.Now:yyyy-MM-dd HH:mm:ss}");
                writer.WriteLine("---");
                writer.WriteLine($"Success: {stackResult.Success}");
                writer.WriteLine($"Message: {stackResult.Message}");
                writer.WriteLine($"CurrentSize: {stackResult.CurrentSize}");
                writer.WriteLine($"PoppedValue: {(stackResult.PoppedValue.HasValue ? stackResult.PoppedValue.Value.ToString() : "null")}");
                writer.WriteLine($"PeekedValue: {(stackResult.PeekedValue.HasValue ? stackResult.PeekedValue.Value.ToString() : "null")}");
                writer.WriteLine("StackState: " + string.Join(",", stackResult.CurrentStackState));
                writer.WriteLine("---");
            }

            LogManager.Log(LogLevel.INFO, $"Results saved successfully to {filePath}");
        }
        catch (Exception ex)
        {
            LogManager.Log(LogLevel.ERROR, $"Failed to save results: {ex.Message}");
            throw;
        }
    }

    public void Push(StackOnLinkedListSettings settings, int value)
    {
        LogManager.Log(LogLevel.INFO, $"Push({value}) called");
        settings.DataCollection.AddFirst(value);
        settings.CollectionSize = settings.DataCollection.Count;
        LogManager.Log(LogLevel.DEBUG, $"Stack size after push: {settings.DataCollection.Count}");
    }

    public int? Pop(StackOnLinkedListSettings settings)
    {
        LogManager.Log(LogLevel.INFO, "Pop called");

        if (settings.DataCollection.Count == 0)
        {
            LogManager.Log(LogLevel.WARNING, "Cannot pop from empty stack");
            return null;
        }

        var value = settings.DataCollection.First.Value;
        settings.DataCollection.RemoveFirst();
        settings.CollectionSize = settings.DataCollection.Count;

        LogManager.Log(LogLevel.INFO, $"Popped value: {value}");
        return value;
    }

    public int? Peek(StackOnLinkedListSettings settings)
    {
        LogManager.Log(LogLevel.INFO, "Peek called");

        if (settings.DataCollection.Count == 0)
        {
            LogManager.Log(LogLevel.WARNING, "Cannot peek empty stack");
            return null;
        }

        var value = settings.DataCollection.First.Value;
        LogManager.Log(LogLevel.INFO, $"Peeked value: {value}");
        return value;
    }

    public bool IsEmpty(StackOnLinkedListSettings settings)
    {
        var isEmpty = settings.DataCollection.Count == 0;
        LogManager.Log(LogLevel.DEBUG, $"IsEmpty: {isEmpty}");
        return isEmpty;
    }

    public void Clear(StackOnLinkedListSettings settings)
    {
        LogManager.Log(LogLevel.INFO, "Clearing stack");
        settings.DataCollection.Clear();
        settings.CollectionSize = 0;
    }
}
