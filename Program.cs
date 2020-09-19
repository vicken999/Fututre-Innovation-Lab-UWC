using System;

namespace Assignment2
{
    public class apples
    {
        public static void Main(string[] args)
        {
            int beerNum = 99;
            String word = "bottles";

            while (beerNum > 0)
            {

                if (beerNum == 1)
                {
                    word = "bottle"; // ONE bottle
                }

                Console.WriteLine(beerNum + " " + word + " of beer on the wall, " + beerNum + " " + word + " of beer");
                beerNum = beerNum - 1;

                if (beerNum > 0)
                {
                    Console.WriteLine("Take one down, pass it round " + beerNum + " " + word + " of beer");
                }
            }

            if (beerNum == 0)
            {
                Console.WriteLine("No more bottles of beer");
            }

        }
    }
}
