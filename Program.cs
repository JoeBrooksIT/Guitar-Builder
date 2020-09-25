using System;
using System.Security.Cryptography.X509Certificates;

namespace Choose_Your_Class
{
    class Program
    {
        // ***GUITAR BUILDER***

        // what type of guitar do you want to build?
        // 1. Left Or RightHanded
        // 2. acoustic or electric
        // 3. Guitar or Bass (bool)
        // 4. number of strings 
        // 5. color
           
        

        
        




        static void Main(string[] args)
        {
            Guitar newGuitar = new Guitar();
            Console.WriteLine("Welcome to GUITAR BUILDER!");
            Console.WriteLine();
            Console.WriteLine("Do you want Left or Right handed? Press 1 for Left, Press Any Key for Right");
            string guitarinput = Console.ReadLine();

            if (guitarinput == "1")

            {
                Console.WriteLine("You selected Left Handed");
                newGuitar.IsRightHanded = false;
            }
            else
            {
                Console.WriteLine("You selected Right Handed");
                newGuitar.IsRightHanded = true;
            }
            Console.WriteLine("Do you want an Acoustic or Electric? Press 1 for Acoustic, press any key for Electric");
            string isElecticInput = Console.ReadLine();

            if (isElecticInput == "1") 
            {
                Console.WriteLine("You selected Acoustic");
                newGuitar.IsElectric = false;
            }
            else
            {
                Console.WriteLine("You selected Electric");
                newGuitar.IsElectric = true;
            }
            Console.WriteLine("Do you want a Guitar or Bass? Press 1 for Guitar, press any key for Bass");
            string isGuitarInput = Console.ReadLine();

            if (isGuitarInput == "1")
            {
                Console.WriteLine("You selected Guitar");
                newGuitar.IsGuitar = true;
            }
            else
            {
                Console.WriteLine("You selected Bass");
                newGuitar.IsGuitar = false;
            }
            Console.WriteLine("How many strings do you want?");
            newGuitar.Strings = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You selected " + newGuitar.Strings);
            Console.WriteLine("What color would you like?");
            newGuitar.Color = Console.ReadLine();

            bool playGuitar = true;
            while (playGuitar)
            {
                Console.Clear();
                Console.WriteLine("GUITAR\n");
                Console.WriteLine("Do you want to tune your guitar?");
                Console.WriteLine("Do you want to play your guitar?");
                Console.WriteLine("Do you want to restring your guitar?");
                Console.WriteLine("Exit");
                
                
                string userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        tuneGuitar();
                        break;
                    case "2":
                        playGuitar();
                        break;
                    case "3":
                        Restring();
                        break;
                    case "4":
                        playGuitar = false;
                        Console.WriteLine("EXIT");
                        break;
                    default:
                        break;
                }
            }

        }
    }
}
