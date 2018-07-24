using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Events
{
    public class Herbivore
    {
        public delegate void HerbivoreStateHandler(string message);
        public event HerbivoreStateHandler GetEaten;

        private int _mass;
        private int neededMass = 4;

        public Herbivore()
        {
            _mass = 1;
        }

        public int CurrentMass
        {
            get { return _mass; }
            set { _mass = value; }
        }

        public int NeededMass { get => neededMass; set => neededMass = value; }

        public void Eaten(Carnivore carnivore)
        {
            if (_mass >= carnivore.NeededMass)
            {
                CurrentMass = 1;
                carnivore.CurrentMass++;
                if (GetEaten != null)
                    GetEaten("Herbivore get eaten");
            }
        }
    }
}
