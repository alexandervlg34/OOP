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

        private List<Player> players = new List<Player>();

        public void AddPlayer(Player player)
        {
            players.Add(player);
        }

        public void RemovePlayer(Player player)
        {
            foreach (Player playerFromList in players)
            {
                if (playerFromList == player) // playerFromList.Equals(player)
                {
                    players.Remove(player);
                }
            }
            
        }

        public void BanByID(Player player, int id)
        {
            if (player.Id == id)
            {
                player.IsBanned = true;
            }
            else
            {
                Console.WriteLine("Игрок с таким ID не найден");
            }
        }

        public void UnBanByID(Player player, int id)
        {
            if (player.Id == id)
            {
                player.IsBanned = false;
            }
            else
            {
                Console.WriteLine("Игрок с таким ID не найден");
            }
        }
    }
}
