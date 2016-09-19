using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome! Here is your virtual pet owl!");

            //can now acces class VirtualPet

            VirtualPet owl = new VirtualPet(10,10,10);

            Console.WriteLine("Please name your pet owl.");
            owl.Name = Console.ReadLine();

            Console.Clear();

            //creating loop so user can continue to play until they quit

            while(true)
            { 
                //owl ascii art
                Console.WriteLine();
                Console.WriteLine(" {0,0}");
                Console.WriteLine(" ./)_)");
                Console.WriteLine("  \" \"");
                
                
                Console.WriteLine(owl.Name + " is a lovable owl with pink polka-dotted feathers and enjoys flying across the sky.");
                Console.WriteLine("Do not let your owl's status reach above 40 in any categorie or your owl will die.");

                //calls current status of hunger,waste, and boredom
                owl.Status();

                //if any are above 40 the loop will be broken and the game is set to quit
                if(owl.Hunger>=40 || owl.Waste>=40 || owl.Boredom>=40)
                {
                    break;
                }

                //options for user to choose from to interact with pet
                Console.WriteLine("Please take care of your pet owl. What would you like to do?");
                Console.WriteLine("1 = Feed your owl");
                Console.WriteLine("2 = Take your owl to the bathroom");
                Console.WriteLine("3 = Play with your owl");
                Console.WriteLine("4 = Quite Game");

                //depending on the number the user chooses that method will be called into action using switch case or the program will quit
                int userInput = int.Parse(Console.ReadLine());

                switch(userInput)
                {
                    case 1:
                        owl.Feed();
                        break;

                    case 2:
                        owl.Bathroom();
                        break;

                    case 3:
                        owl.Play();
                        break;

                    case 4:
                        quit();
                        break;

                    default:
                        Console.WriteLine("How dare you ignore your pet.");
                        quit();
                        break;
                }

                //calling tick method which increases hunger and boredom at the end of each turn
                owl.Tick();

                //clears current feed and new view will have current status updated
                Console.Clear();
                
            }

            quit();


        }

        //created quit method to end program
        static void quit()
        {
            Console.WriteLine("You have neglected to take care of your virtual pet owl.");
            Console.WriteLine("Please say goodbye.");
            Environment.Exit(0);
        }
    }
}
