using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class VirtualPet
    {

        //fields

        private string name;
        private int hunger;
        private int waste;
        private int boredom;


        //properties

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        
        public int Hunger
        {
            get { return this.hunger; }
            set { this.hunger = value; }
        }

        public int Waste
        {
            get { return this.waste; }
            set { this.waste = value; }
        }

        public int Boredom
        {
            get { return this.boredom; }
            set { this.boredom = value; }
        }

        //constructors

        public VirtualPet(int hunger, int waste, int boredom)
        {
            this.hunger = hunger;
            this.waste = waste;
            this.boredom = boredom;
        }

        //methods

        public void Feed()
        {
            hunger = hunger - 5;
            waste = waste + 5;
        }

        public void Bathroom()
        {
            waste = waste - 10;
            boredom = boredom + 5;
        }

        public void Play()
        {
            boredom = boredom - 7;
            hunger = hunger + 10;
        }

        public void Tick()
        {

        }
    }
}
