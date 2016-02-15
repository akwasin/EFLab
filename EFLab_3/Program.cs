using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFLab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new ChampionshipContext())
            {
                Player player = new Player()
                {
                    PlayerName = "Awesome Gamer", PlayerEnrollmentDate = DateTime.Now};
                    ctx.Player.Add(player);
                    ctx.SaveChanges();
            }
        }
    }
}
