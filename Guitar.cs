using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

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
