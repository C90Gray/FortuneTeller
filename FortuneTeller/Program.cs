using System;

namespace FortuneTeller 
{
    class Program
    {
        static void Main(string[] args)
        {
            //welcome Message
            Console.WriteLine("                                 Welcome to:");
            Console.WriteLine("");
            Console.WriteLine("          __  __  __  ___              __   ___  __         __  __");
            Console.WriteLine("          |_ |  | |_|  |  |  |  |'.  | |_    |   |_  |  |   |_  |_| ");
            Console.WriteLine("          |  |__| |'.  |  |__|  |  '.| |_    |   |_  |_ |_  |_  |'.");
            Console.WriteLine("");
            Console.WriteLine("                           You may quit at any time");
            Console.WriteLine("");
            Console.WriteLine("                         Press any key to continue...");
            Console.ReadLine();

            //Variable List
            string nameFirst, nameLast, color, quit;
            string vHome = " ";
            string transport = " ";
            double money = 0.00;
            int retire = 1;
            int age, birth, siblings;
            Console.WriteLine("Please enter your first name.");
            nameFirst = Console.ReadLine().ToLower();
            //char[] firstName = nameFirst.ToCharArray();
            //firstName[0] = char.ToUpper(firstName[0]);
            //firstName.ToString();
            if (nameFirst == "quit")
            {
                Console.WriteLine("");
                Console.WriteLine("Nobody likes a quitter...");
                return;
            }
            Console.WriteLine("");
            Console.WriteLine("Thank you. Please enter your last name.");
            nameLast = Console.ReadLine().ToUpper();
            if (nameLast == "QUIT")
            {
                Console.WriteLine("");
                Console.WriteLine("Nobody likes a quitter...");
                return;
            }
            Console.WriteLine("");
            Console.WriteLine("Please enter your age.");
            quit = Console.ReadLine().ToLower(); 
            if (quit == "quit")
            {
                Console.WriteLine("");
                Console.WriteLine("Nobody likes a quitter...");
                return;
            }
            else
            {
                age = int.Parse(quit);
            }
            Console.WriteLine("");
            Console.WriteLine("Please use a number to write your birth month.");
            quit = Console.ReadLine().ToLower();
            if (quit == "quit")
            {
                Console.WriteLine("");
                Console.WriteLine("Nobody likes a quitter...");
                return;
            }
            else
            {
                birth = int.Parse(quit);
            }
            Console.WriteLine("");
            Console.WriteLine("Please select your favorite ROYGBIV color. \nIf you are unsure what this is asking, please enter Help");
            color = Console.ReadLine().ToLower();
            if (color == "quit")
            {
                Console.WriteLine("");
                Console.WriteLine("Nobody likes a quitter...");
                return;
            }
            //This section will run a switch statement to either store their favorite color as variable color, or to run the Help sequence
            switch (color)
            {
                case ("red"):
                    color = "red";
                    break;

                case ("orange"):
                    color = "orange";
                    break;
                case ("yellow"):
                    color = "yellow";
                    break;
                case ("green"):
                    color = "green";
                    break;
                case ("blue"):
                    color = "blue";
                    break;
                case ("indigo"):
                    color = "indigo";
                    break;
                case ("violet"):
                    color = "violet";
                    break;
                case ("help"):
                    Console.WriteLine("You may choose one of the following colors: \nRed \nOrange \nYellow \nGreen \nBlue \nIndigo \n or Violet. \nPlease choose a color now.");
                    color = Console.ReadLine().ToLower();
                    if (color == "quit")
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Nobody likes a quitter...");
                        return;
                    }
                    else
                    {
                        break;
                    }
                default:
                    Console.WriteLine("You may choose one of the following colors: \nRed \nOrange \nYellow \nGreen \nBlue \nIndigo \n or Violet. \nPlease choose a color now.");
                    color = Console.ReadLine().ToLower();
                    if (color == "quit")
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Nobody likes a quitter...");
                        return;
                    }
                    else
                    {
                        break;
                    }
            }
            Console.WriteLine("");
            Console.WriteLine("Please enter the number of siblings you have.");
            quit = Console.ReadLine().ToLower();
            if (quit == "quit")
            {
                Console.WriteLine("");
                Console.WriteLine("Nobody likes a quitter...");
                return;
            }
            else
            {
                siblings = int.Parse(quit);
            }
            //switch to assign vacation homes to different number of siblings

            switch (siblings)
            {
                case (0):
                    vHome = "Hawaii";
                    break;
                case (1):
                    vHome = "Panama City";
                    break;
                case (2):
                    vHome = "Jamaica";
                    break;
                case (3):
                    vHome = "Los Vagas";
                    break;
                default:
                    Console.WriteLine("");
                    break;
                    
            }
            //Would have to build a loop if I want the default result to function. Hopfully the user inputs a value
            //Can't do mathmatical equations in switch so need to do if statement

           if (siblings > 3)
            {
                vHome = "Canada";
            }
           if (siblings < 0)
            {
                vHome = "a landfill";
            }
           //Now I will use a second color switch reassign the color options to represent modes of transportation
           switch (color)
            {
                case ("red"):
                    transport = "camel";
                    break;

                case ("orange"):
                    transport = "horse and buggy";
                    break;


                case ("yellow"):
                    transport = "rusty bicycle";
                    break;

                case ("green"):
                    transport = "pair of roller blades";
                    break;

                case ("blue"):
                    transport = "Lamborghini Veneno";
                    break;

                case ("indigo"):
                    transport = "Porsche Cayman";
                    break;

                case ("violet"):
                    transport = "Private Jet";
                    break;
            
            }

            //This section assigns the birthmonth to a monetary value using an if then statement
            if ((birth >= 1) && (birth <=4))
            {
                money = 100.13;
            }
            else if  ((birth >= 5) && (birth <=8))
            {
                money = 20000.17;
            }
            else if ((birth >= 9 && (birth <=12)))
            {
                money = 9420360.37;
            }
            else
            {
                money = 0.00;
            }
            // Figureing out retirment years based on age using modulus to detirmine if age is odd or even
            if (age%2==0)
            {
                retire = 30;
            }
            else
            {
                retire = 5;
            }
            Console.WriteLine("");
            Console.WriteLine("Thank you for your info. Fortune Teller is now calculating your fortune.");
            Console.WriteLine("");
            Console.WriteLine("Thank you for using Fortune Teller. \nPress any key for your results.");
            Console.ReadLine();
            Console.WriteLine("{0} {1} will retire in {2} years with ${3} in the bank, \na vacation home in {4}, and a {5}.", nameFirst, nameLast, retire, money, vHome, transport);
            Console.WriteLine("");
        }

    }

}


