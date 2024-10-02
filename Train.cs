using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Train
    {
        List<Railcar> railCars = new List<Railcar>();
        Railcar Railcar = new Railcar();
        Manager Manager = new Manager();

        public void AddRailCars()
        {
           for (int i = 0; i < Math.Ceiling((float)(Railcar.Seats.Length / Manager.NumberOfPassengers)); i++)
            {
                Railcar Railcar = new Railcar();
                railCars.Add(Railcar);
            }
           
        }
    }
}
