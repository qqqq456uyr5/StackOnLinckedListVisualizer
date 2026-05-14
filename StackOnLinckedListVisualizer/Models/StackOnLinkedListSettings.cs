

namespace StackOnLinckedListVisualizer.Models;

[Serializable]
public class StackOnLinkedListSettings : AlgorithmSettings
{
    public LinkedList<int> DataCollection { get; set; }

    public StackOnLinkedListSettings() : base()
    {
        DataCollection = new LinkedList<int>();
        AlgorithmName = "Stack on Linked List";
        Description = "Stack implementation using singly linked list logic";
    }


    public override string GetSettingsInfo()
    {
        return base.GetSettingsInfo() + $"\nCurrent stack size: {DataCollection.Count}";
    }
}
