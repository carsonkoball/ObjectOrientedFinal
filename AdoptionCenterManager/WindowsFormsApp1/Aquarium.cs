using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Aquarium : Environment
    {
        private void Init(int id, string inhabitant, double waterph)
        {
            this.ID = id;
            this.Inhabitant = inhabitant;
            this.WaterpH = waterph;
            this.LastTimeCleaned = DateTime.Now;
            this.LastTimeFed = DateTime.Now;
            Console.WriteLine("Aquarium created...");
        }
        public Aquarium(int id, string inhabitant, double waterph)
        {
            this.Init(id, inhabitant, waterph);
        }

        public Aquarium(int id, string inhabitant)
        {
            this.Init(id, inhabitant, 7);
        }
    }
}
