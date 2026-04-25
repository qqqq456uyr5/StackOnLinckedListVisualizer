namespace StackOnLinckedListVisualizer.Models;

public abstract class AlgorithmSettings
{
    public string AlgorithmName { get; set; }
    public string Description { get; set; }
    public int CollectionSize { get; set; }
    public DateTime CreatedAt { get; set; }

    protected AlgorithmSettings()
    {
        AlgorithmName = "Unknown Algorithm";
        Description = "No description";
        CollectionSize = 0;
        CreatedAt = DateTime.Now;
    }

    protected AlgorithmSettings(string algorithmName, string description, int collectionSize)
    {
        AlgorithmName = algorithmName;
        Description = description;
        CollectionSize = collectionSize;
        CreatedAt = DateTime.Now;
    }

    public virtual string GetSettingsInfo()
    {
        return $"Algorithm: {AlgorithmName}\nDescription: {Description}\nSize: {CollectionSize}\nCreated: {CreatedAt}";
    }


}
