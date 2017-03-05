using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern
{
    abstract class Game
    {
        public abstract void Initialize();
        public abstract void StartGame();
        public abstract void EndGame();

        public virtual void PlayGame()
        {
            this.Initialize();
            this.StartGame();
            this.EndGame();
        }
    }
}
