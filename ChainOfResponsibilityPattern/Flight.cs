using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportChainOfResponsibilities
{
    class Flight
    {
        public string Type { get; set; }
        
        public string ModelPlane { get; set; }
        public int Weight { get; set; }

        public string Nationality { get; set; }

        public Flight(string type,string modelPlane, int weight, string nationality)
        {
            this.Type = type;
            this.ModelPlane = modelPlane;
            this.Weight = weight;
            this.Nationality = nationality;
        }
    }
}
