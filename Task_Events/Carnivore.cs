using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Events
{
    public class Carnivore
    {
        private int _mass;
        private int neededMass = 3;

        public Carnivore()
        {
            _mass = 1;
        }

        public int CurrentMass
        {
            get { return _mass; }
            set { _mass = value; }
        }

        public int NeededMass { get => neededMass; set => neededMass = value; }
    }
}
