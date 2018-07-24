using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Events
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Plant plant = new Plant();
                Herbivore herbivore = new Herbivore();
                Carnivore carnivore = new Carnivore();

                plant.Feeding += Show_Message;
                plant.GetEaten += Show_Message;
                herbivore.GetEaten += Show_Message;

                bool exit = false;

                while (!exit)
                {

                    Console.Clear();
                    Console.WriteLine("Menu:");
                    Console.WriteLine("1. Feed plant");
                    Console.WriteLine("2. Show current mass of plant");
                    Console.WriteLine("3. Show current mass of herbivore");
                    Console.WriteLine("4. Show current mass of carnivore");
                    Console.WriteLine("0. Exit");
                    int select = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    switch (select)
                    {
                        case 1:
                            {
                                plant.FeedPlant(herbivore, carnivore);
                                Console.WriteLine("Press any button to contunue");
                                Console.ReadKey();
                                break;
                            }
                        case 2:
                            {
                                Console.WriteLine("Plant's current mass: {0}", plant.CurrentMass);
                                Console.WriteLine("Press any button to contunue");
                                Console.ReadKey();
                                break;
                            }
                        case 3:
                            {
                                Console.WriteLine("Herbivore's current mass: {0}", herbivore.CurrentMass);
                                Console.WriteLine("Press any button to contunue");
                                Console.ReadKey();
                                break;
                            }
                        case 4:
                            {
                                Console.WriteLine("Carnivore's current mass: {0}", carnivore.CurrentMass);
                                Console.WriteLine("Press any button to contunue");
                                Console.ReadKey();
                                break;
                            }
                        case 0:
                            {
                                Console.Clear();
                                Console.WriteLine("Thank u for using this software. Good luck!");
                                Console.WriteLine("Press any button to exit");
                                Console.ReadKey();
                                exit = true;
                                break;
                            }
                        default: break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }

        private static void Show_Message(string message)
        {
            Console.WriteLine(message);
        }
    }
}
