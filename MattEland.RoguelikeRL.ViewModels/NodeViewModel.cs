using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MattEland.RoguelikeRL.Models;
using MattEland.RoguelikeRL.Models.Networks;

namespace MattEland.RoguelikeRL.ViewModels
{
    public class NodeViewModel : ViewModelBase
    {
        private readonly NetworkNode _node;

        public NodeViewModel(NetworkNode node)
        {
            _node = node;
        }

        public double Offset => (-Width / 2.0);

        public double X => Offset + (_node.Position.X * Scale);
        public double Y => Offset + (_node.Position.Y * Scale);

        public double Width => 1500 / Scale; // Designed for a base scale of 30 having a width of 50
        public double Height => Width;

        public int Scale => 30;

        public string Name => _node.Name;
    }
}
