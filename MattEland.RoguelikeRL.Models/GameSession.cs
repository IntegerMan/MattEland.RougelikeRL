using MattEland.RoguelikeRL.Models.Networks;

namespace MattEland.RoguelikeRL.Models
{
    /// <summary>
    /// Represents an ongoing run through a game
    /// </summary>
    public sealed class GameSession
    {
        public GameSession() : this(new NetworkBuilder())
        {
        }

        public GameSession(NetworkBuilder builder)
        {
            ActiveNetwork = builder.BuildSampleLevel();
        }

        /// <summary>
        /// Gets the current status of the session
        /// </summary>
        public SessionStatus Status => SessionStatus.Active;

        public Network ActiveNetwork { get; }
    }
}
