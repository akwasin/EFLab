using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFLab_2
{
    class Game
    {
        public int GameId { get; set; }
        public string GameName { get; set; }
        public ICollection<Player> Players { get; set; } 
    }
}
