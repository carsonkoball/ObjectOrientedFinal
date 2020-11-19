using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public abstract class Environment
    {
        protected virtual string Inhabitant { get; set; }
        protected virtual double WaterpH { get; set; }
        protected virtual int ID { get; set; }
        protected virtual int NumberOfInhabitants { get; set; }
        protected virtual DateTime LastTimeCleaned { get; set; }
        protected virtual DateTime LastTimeFed { get; set; }


        public void Clean()
        {
            this.LastTimeCleaned = DateTime.Now;

        }

        public void Feed()
        {
            this.LastTimeFed = DateTime.Now;
        }

        public DateTime GetLastTimeCleaned()
        {
            return this.LastTimeCleaned;
        }

        public DateTime GetLastTimeFed()
        {
            return this.LastTimeFed;
        }

        public string GetInhabitant()
        {
            return this.Inhabitant;
        }

        public void AddInhabitants(int numberofinhabitants)
        {
            this.NumberOfInhabitants += numberofinhabitants;
        }

        public void RemoveInhabitants(int numberofinhabitants)
        {
            this.NumberOfInhabitants -= numberofinhabitants;
        }

        public int GetNumberOfInhabitants()
        {
            return this.NumberOfInhabitants;
        }

        public int GetID()
        {
            return this.ID;
        }
        public double GetWaterpH()
        {
            return this.WaterpH;
        }

        public void UpdateWaterpH(double waterph)
        {
            this.WaterpH = waterph;
        }
    }
}
