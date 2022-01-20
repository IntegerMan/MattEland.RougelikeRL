using System.Collections.ObjectModel;
using MattEland.RoguelikeRL.Models;

namespace MattEland.RoguelikeRL.ViewModels
{
    // All the code in this file is included in all platforms.
    public sealed class GameViewModel : ViewModelBase
    {
        private readonly GameSession _session;
        private readonly ObservableCollection<NodeViewModel> _nodes = new();

        public GameViewModel(GameSession session)
        {
            _session = session;

            UpdateNodes();
        }

        private void UpdateNodes()
        {
            _nodes.Clear();

            foreach (var node in _session.ActiveNetwork.Nodes)
            {
                _nodes.Add(new NodeViewModel(node));
            }
        }

        public string Test => "Contact Matt Eland (@IntegerMan) with any questions";
        public string Title => "Emergence RL Prototype";

        public ObservableCollection<NodeViewModel> Nodes => _nodes;

    }
}