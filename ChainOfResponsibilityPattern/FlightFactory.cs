using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportChainOfResponsibilities
{
    class FlightFactory
    {
        public Flight GetFlight(FlightType flightType)
        {
            switch (flightType)
            {

                case FlightType.Civil:
                    return new Flight("Civil", "k500", 6,"bulgarian");
                case FlightType.Charter:
                    return new Flight("Charter", "e600", 4, "romanian");
                case FlightType.Training:
                    return new Flight("Training", "b100", 1, "bulgarian");
                case FlightType.Aircraft:
                    return new Flight("Aircraft", "c2", 3, "greek");
                case FlightType.Irregular:
                    return new Flight("Irregular", "e250", 3, "italian");
                case FlightType.International:
                    return new Flight("International", "g70", 6, "bulgarian");
                case FlightType.State:
                    return new Flight("State", "gp60", 2, "english");
                default:
                    throw new ArgumentException();
                    
            }
        }
    }
}
