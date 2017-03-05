using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern
{
    class Football: Game
    {
        public override void Initialize()
        {
            Console.WriteLine("Initialize football");
        }

        public override void StartGame()
        {
            Console.WriteLine("Start game football");
        }

        public override void EndGame()
        {
            Console.WriteLine("End game football");
        }

        public override void PlayGame()
        {
            base.PlayGame();
        }
    }
}
