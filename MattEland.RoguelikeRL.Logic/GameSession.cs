using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MattEland.RoguelikeRL.Logic
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
