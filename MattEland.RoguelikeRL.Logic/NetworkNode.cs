namespace MattEland.RoguelikeRL.Logic;

/// <summary>
/// Represents a node inside of a given <see cref="Network"/>. This is an area that the player will be located in and can move to other nodes.
/// </summary>
public sealed class NetworkNode
{
    public NetworkNode() : this("Unknown")
    {

    }

    public NetworkNode(string name) : this(name, new NetworkPos(5,5))
    {
    }

    public NetworkNode(string name, NetworkPos position)
    {
        this.Name = name;
        this.Position = position;
    }

    /// <summary>
    /// Represents the node's central position in the network
    /// </summary>
    public NetworkPos Position { get; set; }

    /// <summary>
    /// Gets the name of the network node
    /// </summary>
    public string Name { get; }
}