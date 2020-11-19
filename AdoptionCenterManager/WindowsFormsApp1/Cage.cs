using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Cage : Environment
    {
        private void Init(int id, string inhabitant)
        {
            this.ID = id;
            this.Inhabitant = inhabitant;
            this.WaterpH = 0;
            this.LastTimeCleaned = DateTime.Now;
            this.LastTimeFed = DateTime.Now;
            Console.WriteLine("Cage created...");
        }

        public Cage(int id, string inhabitant)
        {
            this.Init(id, inhabitant);
        }
    }
}
