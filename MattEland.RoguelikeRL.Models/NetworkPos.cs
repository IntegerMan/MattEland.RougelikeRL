namespace MattEland.RoguelikeRL.Models;

/// <summary>
/// Represents a position within a network
/// </summary>
public record NetworkPos(int X, int Y)
{
    /// <summary>
    /// Creates a new <see cref="NetworkPos"/> instance related to the old position modified by the <paramref name="xDiff"/> and <paramref name="yDiff"/> parameters.
    /// </summary>
    /// <param name="xDiff">The amount to modify the new instance's X position relative to this instance's X position</param>
    /// <param name="yDiff">The amount to modify the new instance's Y position relative to this instance's Y position</param>
    /// <returns>The new NetworkPos instance</returns>
    public NetworkPos AdjustPosition(int xDiff, int yDiff)
    {
        return new NetworkPos(X + xDiff, Y + yDiff);
    }
}