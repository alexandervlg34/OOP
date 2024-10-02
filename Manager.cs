using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    enum Status 
    {
        OnStation,
        OnTheMove
    }
    public class Manager
    {
        private int numberOfPassengers;

        public int NumberOfPassengers { get { return numberOfPassengers; } }

        Railcar Railcar = new Railcar();
        Train Train = new Train();
        List<Train> trains = new List<Train>();

        Status Status = Status.OnStation;

        public void AddPassenger()
        {
            if(numberOfPassengers < Railcar.Seats.Length)
            {
                numberOfPassengers++;
            }
        }

        // отправление поезда 
        public void CreateDirection()
        {
            trains.Add(new Train());


            if(Status == Status.OnStation)
            {
                Random random = new Random();

                Direction direction = new Direction(1, random.Next(2, 10));

                Status = Status.OnTheMove;

                if (trains.Count > 0)
                {
                    trains.Remove(trains[0]);
                }
            }

            Status = Status.OnStation;
        }



    }
}
