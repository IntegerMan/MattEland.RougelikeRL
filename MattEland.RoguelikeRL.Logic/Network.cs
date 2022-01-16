namespace MattEland.RoguelikeRL.Logic;

/// <summary>
/// Represents a collection of network nodes. This is the equivalent of a game level or floor in a dungeon.
/// </summary>
public class Network
{
    private readonly List<NetworkNode> _nodes = new();

    /// <summary>
    /// Gets the nodes inside of this network
    /// </summary>
    public IEnumerable<NetworkNode> Nodes => _nodes;

    /// <summary>
    /// Gets the number of nodes in the network
    /// </summary>
    public int NumNodes => _nodes.Count;

    /// <summary>
    /// Adds a new node to the network
    /// </summary>
    /// <param name="node">The node to add. Cannot be null</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="node"/> was null</exception>
    public void Add(NetworkNode node)
    {
        if (node == null) throw new ArgumentNullException(nameof(node));

        _nodes.Add(node);
    }
}