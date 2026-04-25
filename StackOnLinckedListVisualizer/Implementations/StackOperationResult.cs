namespace StackOnLinckedListVisualizer.Implementations;

public class StackOperationResult
{
    public bool Success { get; set; }
    public string Message { get; set; }
    public int? PoppedValue { get; set; }
    public int? PeekedValue { get; set; }
    public int CurrentSize { get; set; }
    public List<int> CurrentStackState { get; set; }

    public StackOperationResult()
    {
        CurrentStackState = new List<int>();
    }
}
