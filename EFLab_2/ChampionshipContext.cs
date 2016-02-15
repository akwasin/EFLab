using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFLab_2
{
    class ChampionshipContext : DbContext
    {
        public DbSet<Player> Player { get; set; } 
        public DbSet<Game> Games { get; set; } 
    }
}
