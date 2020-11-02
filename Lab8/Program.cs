using System;
using System.Reflection.Metadata.Ecma335;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "Ivan", "Tim", "Sam", "Homie", "Dude" };
            string[] city = new string[] { "Detroit", "Cityville", "Metropolis", "Flint", "Big Town" };
            string[] food = new string[] { "Ramen", "Chiccy Nugs", "Cheetos", "Water", "Pizza" };
            bool isRunning = true;

            while (isRunning)
            {
                try
                {
                    Console.WriteLine("Enter a number 1-5 to look up a user: ");
                    int userinput = int.Parse(Console.ReadLine()) - 1;
                    Console.WriteLine();

                    if (userinput == 0)
                    {
                        PrintUser(names[userinput], city[userinput], food[userinput]);
                        bool continueCheck = AskContinue();

                        if (continueCheck == true)
                        {
                            continue;
                        }
                        else
                        {
                            break;
                        }
                    }
                    else if (userinput == 1)
                    {
                        PrintUser(names[userinput], city[userinput], food[userinput]);
                        bool continueCheck = AskContinue();

                        if (continueCheck == true)
                        {
                            continue;
                        }
                        else
                        {
                            break;
                        }
                    }
                    else if (userinput == 2)
                    {
                        PrintUser(names[userinput], city[userinput], food[userinput]);
                        bool continueCheck = AskContinue();

                        if (continueCheck == true)
                        {
                            continue;
                        }
                        else
                        {
                            break;
                        }
                    }
                    else if (userinput == 3)
                    {
                        PrintUser(names[userinput], city[userinput], food[userinput]);
                        bool continueCheck = AskContinue();

                        if (continueCheck == true)
                        {
                            continue;
                        }
                        else
                        {
                            break;
                        }
                    }
                    else if (userinput == 4)
                    {
                        PrintUser(names[userinput], city[userinput], food[userinput]);
                        bool continueCheck = AskContinue();

                        if (continueCheck == true)
                        {
                            continue;
                        }
                        else
                        {
                            break;
                        }
                    }
                    else 
                    {
                        Console.WriteLine("Please enter a number between 1-5 \n");
                    }

                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine(e.StackTrace);
                }
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine(e.StackTrace);
                }
            }



        }
        public static void PrintUser(string name, string city, string food)
        {
            Console.WriteLine($"This is {name} and they are from {city}.  Their favorite food is {food} \n");
        }
        public static bool AskContinue()
        {
            Console.WriteLine("Would you like to look up another user? Type yes to enter another or enter anything else to end the program;");
            string usercontinue = Console.ReadLine();
            Console.WriteLine("\n");

            if (usercontinue == "yes" || usercontinue == "Yes")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
