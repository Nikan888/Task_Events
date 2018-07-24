using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Events
{
    public class Plant
    {
        public delegate void PlantStateHandler(string message);
        public event PlantStateHandler Feeding;
        public event PlantStateHandler GetEaten;

        private int _mass;

        public Plant()
        {
            _mass = 1;
        }

        public int CurrentMass
        {
            get { return _mass; }
            set { _mass = value; }
        }

        public void FeedPlant(Herbivore herbivore, Carnivore carnivore)
        {
            _mass++;
            if (Feeding != null)
                Feeding("You fed the plant");
            if (_mass >= herbivore.NeededMass)
                Eaten(herbivore);
            if (herbivore.CurrentMass >= carnivore.NeededMass)
                herbivore.Eaten(carnivore);
        }

        public void Eaten(Herbivore herbivore)
        {
            CurrentMass = 1;
            herbivore.CurrentMass++;
            if (GetEaten != null)
                GetEaten("Plant get eaten");
        }
    }
}
