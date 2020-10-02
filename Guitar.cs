using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using System.Transactions;

namespace Choose_Your_Class
{
    class Guitar
    { // ***GUITAR BUILDER***
        public bool IsRightHanded { get; set; }
        public bool IsElectric { get; set; }
        public bool IsGuitar { get; set; }
        public int Strings { get; set; }
        public string Color { get; set; }
        public int StringLife { get; set; }
        public bool IsTuned { get; set; }
        //Constructor
        public Guitar()
        {
            StringLife = 100;
            IsTuned = true;
        }
        public Guitar(bool isRightHanded, bool isElectric, bool isGuitar, int strings, string color)
        {
            IsRightHanded = isRightHanded;
            IsElectric = isElectric;
            IsGuitar = isGuitar;
            Strings = strings;
            Color = color;
            
        }
        public void currentSpecs()
        {
            Console.WriteLine("These are you current specs" + "");
            if (IsRightHanded)
            {
                Console.WriteLine("Your guitar is right handed");
            }
            else
            {
                Console.WriteLine("Your guitar is left handed");
            }
            if (IsElectric)
            {
                Console.WriteLine("Your guitar is Electric");
            }
            else
            {
                Console.WriteLine("Your guitar is acoustic");
            }
            if (IsGuitar)
            {
                Console.WriteLine("You selected guitar");
            }
            else
            {
                Console.WriteLine("You selected bass");
            }
            if (IsTuned)
            {
                Console.WriteLine("Your guitar is tuned");
            }
            else
            {
                Console.WriteLine("Your guitar is out of tune");

            }
            Console.WriteLine("Number of strings: " + Strings);
            Console.WriteLine("The color is: " + Color);
            Console.WriteLine("Please enter to return to main menu");
            Console.ReadLine();
        }
        public void restringGuitar()
        {
            StringLife = 100;
            Console.WriteLine("You just restrung your guitar");
        }
        public void tuneGuitar()
        {
            IsTuned = true;
            Console.WriteLine("You just tuned your guitar");
        }
        public void playGuitar()
        {
            if (StringLife < 50)
            {
                Console.WriteLine("You need to restring your guitar");
            }
            else if(IsTuned == false)
            {
                Console.WriteLine("Your guitar might be out of tune");

            }
            else
            {
                Console.WriteLine("You played your guitar");
                StringLife -= 5;
                IsTuned = false;
            }
            
        }

        // what type of guitar do you want to build?
        // 1. left or right handed
        // 2. acoustic or electric
        // 3. Guitar or Bass
        // 4. number of strings 
        // (Guitar - 6,7,8) (Bass - 4,5,6)
        // 5. color
        // 6. exit

    }
}
