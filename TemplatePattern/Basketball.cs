using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern
{
    class Basketball:Game
    {
        public override void Initialize()
        {
            Console.WriteLine("Initialize basketball");
        }

        public override void StartGame()
        {
            Console.WriteLine("Start game basketball");
        }

        public override void EndGame()
        {
            Console.WriteLine("End game basketball");
        }

        public override void PlayGame()
        {
            base.PlayGame();
        }
    }
}
