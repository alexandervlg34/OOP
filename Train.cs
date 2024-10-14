using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Train
    {
        private List<Railcar> railCars = new List<Railcar>(); // модификаторы доступа
        private Railcar Railcar = new Railcar();
        private TrainControlManager TrainControlManager = new TrainControlManager();

        public void AddRailCars()
        {
           for (int i = 0; i < Math.Ceiling((float)(Railcar.Seats.Length / TrainControlManager.NumberOfPassengers)); i++)
            {
                Railcar Railcar = new Railcar();
                railCars.Add(Railcar);
            }
           
        }
    }
}
