namespace MattEland.RoguelikeRL.Models.Networks;

/// <summary>
/// Represents a collection of network nodes. This is the equivalent of a game level or floor in a dungeon.
/// </summary>
public class Network
{
    private readonly List<NetworkNode> _nodes = new();
    private readonly List<NetworkConnection> _connections = new();

    /// <summary>
    /// Gets the nodes inside of this network
    /// </summary>
    public IEnumerable<NetworkNode> Nodes => _nodes;

    /// <summary>
    /// Gets a list of all connections between network nodes
    /// </summary>
    public IEnumerable<NetworkConnection> Connections => _connections;

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

    /// <summary>
    /// Connects two network nodes together
    /// </summary>
    /// <param name="nodeA">The first node to connect</param>
    /// <param name="nodeB">The second node to connect</param>
    public void Connect(NetworkNode nodeA, NetworkNode nodeB)
    {
        // Don't duplicate any existing connections
        if (Connections.Any(c => c.Includes(nodeA) && c.Includes(nodeB)))
        {
            return;
        }

        NetworkConnection connection = new(nodeA, nodeB);
        _connections.Add(connection);
    }
}