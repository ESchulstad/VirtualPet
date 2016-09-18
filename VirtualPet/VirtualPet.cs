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
        //so fields can be accessed

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
        //the actions

        public void Status()
        {
            Console.WriteLine("Hunger = " + hunger);
            Console.WriteLine("Waste = " + waste);
            Console.WriteLine("Boredom = " + boredom);
        }

        public void Feed()
        {
            hunger -= 10;
            waste += 5;
        }

        public void Bathroom()
        {
            waste -= 10;
            boredom += 5;
        }

        public void Play()
        {
            boredom -= 10;
            hunger += 7;
        }

        public void Tick()
        {
            hunger += 3;
            boredom += 6;
        }
    }
}
