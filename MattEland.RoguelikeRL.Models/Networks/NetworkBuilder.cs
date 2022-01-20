namespace MattEland.RoguelikeRL.Models.Networks
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

            var root = new NetworkNode("root", new NetworkPos(5, 5));
            var docs = new NetworkNode("Documents", new NetworkPos(5, 2));
            var downloads = new NetworkNode("Downloads", new NetworkPos(2, 6));
            var appData = new NetworkNode("App Data", new NetworkPos(7, 4));
            var users = new NetworkNode("Users", new NetworkPos(8, 6));
            var progs = new NetworkNode("Programs", new NetworkPos(4, 7));
            var antiVirus = new NetworkNode("Anti-virus", new NetworkPos(3, 9));

            network.Add(docs);
            network.Add(downloads);
            network.Add(root);
            network.Add(appData);
            network.Add(progs);
            network.Add(users);
            network.Add(antiVirus);

            network.Connect(root, docs);
            network.Connect(root, users);
            network.Connect(root, downloads);
            network.Connect(root, progs);
            network.Connect(docs, appData);
            network.Connect(progs, antiVirus);

            return network;
        }
    }
}
