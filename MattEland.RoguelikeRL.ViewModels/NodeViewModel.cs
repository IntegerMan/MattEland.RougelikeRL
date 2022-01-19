using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MattEland.RoguelikeRL.Models;

namespace MattEland.RoguelikeRL.ViewModels
{
    public class NodeViewModel : ViewModelBase
    {
        private readonly NetworkNode _node;

        public NodeViewModel(NetworkNode node)
        {
            _node = node;
        }

        public double X => _node.Position.X * Scale;
        public double Y => _node.Position.Y * Scale;

        public double Width => 5 * Scale;
        public double Height => 5 * Scale;

        public int Scale => 30;

        public string Name => _node.Name;
    }
}
