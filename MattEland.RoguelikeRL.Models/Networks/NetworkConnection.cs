namespace MattEland.RoguelikeRL.Models.Networks;

public sealed class NetworkConnection
{
    public NetworkNode NodeA { get; }
    public NetworkNode NodeB { get; }

    public NetworkConnection(NetworkNode nodeA, NetworkNode nodeB)
    {
        NodeA = nodeA;
        NodeB = nodeB;
    }

    public bool Includes(NetworkNode node) => node == NodeA || node == NodeB;
}