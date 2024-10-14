using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class PlayerDrawer
    {
        PlayerPosition PlayerPosition = new PlayerPosition();
        public void Draw()
        {
            Console.WriteLine($"Player Position: {PlayerPosition.XPosition}, {PlayerPosition.YPosition}");
        }
    }
}
