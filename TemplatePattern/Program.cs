using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Game football = new Football();
            football.PlayGame();
            Game basketball = new Basketball();
            basketball.PlayGame();
        }
    }
}
