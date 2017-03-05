using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportChainOfResponsibilities
{
    class Program
    {
        static void Main(string[] args)
        {
            Approver avio = new AvioOperator();
            Approver fl_manager = new FlightManager();
            Approver air_director = new AirTrafficDirector();
            Approver minister = new TrafficMinister();

            avio.SetSuccessor(fl_manager);
            fl_manager.SetSuccessor(air_director);
            air_director.SetSuccessor(minister);

            var flightfactory = new FlightFactory();

            Flight civil = flightfactory.GetFlight(FlightType.Civil);
            Flight training = flightfactory.GetFlight(FlightType.Training);
            Flight international = flightfactory.GetFlight(FlightType.International);

            avio.ProcessRequest(civil);
            Console.WriteLine();

            avio.ProcessRequest(training);
            Console.WriteLine();

            avio.ProcessRequest(international);

            Console.ReadKey(true);
        }
    }
}
