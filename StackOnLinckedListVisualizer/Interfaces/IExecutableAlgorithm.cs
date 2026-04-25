namespace StackOnLinckedListVisualizer.Interfaces;
using StackOnLinckedListVisualizer.Models;

public interface IExecutableAlgorithm
{
    object Execute(AlgorithmSettings settings);
    void SaveResults(string filePath, object results);
    object LoadResults(string filePath);
}
