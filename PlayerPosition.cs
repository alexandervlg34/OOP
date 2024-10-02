using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class PlayerPosition
    {
        private float xPosition = 10f;
        private float yPosition = 30f;

        public float XPosition { get { return xPosition; } private set { xPosition = value; } }
        public float YPosition { get { return yPosition; } private set { yPosition = value; } }
    }
}
