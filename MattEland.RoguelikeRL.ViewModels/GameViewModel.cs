using System.ComponentModel;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using MattEland.RoguelikeRL.Logic;

namespace MattEland.RoguelikeRL.ViewModels
{
    // All the code in this file is included in all platforms.
    public sealed class GameViewModel : INotifyPropertyChanged
    {
        private GameSession _session = new();

        public string Test => "Hello There!";

        public IEnumerable<NetworkNode> Nodes => _session.ActiveNetwork.Nodes;

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}