using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarneeb
{
    internal class Player
    {
        //Player number - 1-4
        private int playerNumber;
        // A player's hand of cards
        public Hand Hand { get; } = new Hand();

        public Player()
        {
               
        }


    }
}
