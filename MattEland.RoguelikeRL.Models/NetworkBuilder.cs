namespace MattEland.RoguelikeRL.Models
{
    /// <summary>
    /// Generates constructed <see cref="Network"/> instances.
    /// </summary>
    public sealed class NetworkBuilder
    {
        /// <summary>
        /// Builds a sample Network suitable for testing
        /// </summary>
        /// <returns>The new level</returns>
        public Network BuildSampleLevel()
        {
            Network network = new();

            network.Add(new NetworkNode("Documents", new NetworkPos(5, 2)));
            network.Add(new NetworkNode("Downloads", new NetworkPos(8, 6)));
            network.Add(new NetworkNode("root", new NetworkPos(5, 5)));
            network.Add(new NetworkNode("App Data", new NetworkPos(7, 4)));
            network.Add(new NetworkNode("Users", new NetworkPos(8, 6)));
            network.Add(new NetworkNode("Anti-virus", new NetworkPos(3, 9)));

            return network;
        }
    }
}
