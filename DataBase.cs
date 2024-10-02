using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class DataBase
    {
        Player player1 = new Player(1, "John", 10, false);
        Player player2 = new Player(2, "Paul", 13, false);
        Player player3 = new Player(3, "Andrew", 1, true);
        Player player4 = new Player(4, "Vito", 100, true);
        Player player5 = new Player(5, "Kevin", 34, false);

        List<Player> players = new List<Player>();

        public void AddPlayer(Player player)
        {
            players.Add(player);
        }

        public void RemovePlayer(Player player)
        {
            players.Remove(player);
        }

        public void BanByID(Player player, int id)
        {
            if (player.Id == id)
            {
                player.IsBanned = true;
            }
        }

        public void UnBanByID(Player player, int id)
        {
            if (player.Id == id)
            {
                player.IsBanned = false;
            }
        }
    }
}
