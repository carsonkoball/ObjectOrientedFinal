using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Terrarium : Environment
    {
        private void Init(int id, string type)
        {
            this.ID = id;
            this.Inhabitant = type;
            this.LastTimeCleaned = DateTime.Now;
            this.LastTimeFed = DateTime.Now;
            this.WaterpH = 0;
            Console.WriteLine("Terrarium created...");
        }

        public Terrarium(int id, string type)
        {
            this.Init(id, type);
        }

    }
}
