using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP
{
    public class Player
    {
        private int id;
        private string name;
        private int level;
        private bool isBanned;

        public int Id {  get { return id; } }
        public bool IsBanned {  get { return isBanned; } set { isBanned = value; } }
        
        public Player(int id, string name, int level, bool isBanned)
        {
            this.id = id;
            this.name = name;
            this.level = level;
            this.isBanned = isBanned;
        }

        public void ShowInformation()
        {
            Console.WriteLine($"ID: {id} Name: {name} Level: {level} Is banned: {isBanned}");
        }
    }
}
