using MattEland.RoguelikeRL.Models.Networks;

namespace MattEland.RoguelikeRL.ViewModels;

public class ConnectionViewModel : ViewModelBase
{
    private readonly NetworkConnection _connection;

    public ConnectionViewModel(NetworkConnection connection)
    {
        _connection = connection;
    }
    public int Scale => 30;
    public int Offset => 0;

    public double X1 => Offset + _connection.NodeA.Position.X * Scale;
    public double X2 => Offset + _connection.NodeB.Position.X * Scale;
    public double Y1 => Offset + _connection.NodeA.Position.Y * Scale;
    public double Y2 => Offset + _connection.NodeB.Position.Y * Scale;
}