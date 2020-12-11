using System;
using System.Collections.Generic;

namespace adventcode
{
    class Program
    {
        static void Main(string[] args)
        {
            // read input and put in list
            string[] lines = System.IO.File.ReadAllLines(@"./dayone_input.txt");
            List<int> puzzleInput = new List<int>();
            try {
                foreach (string item in lines)
                {
                    int val = Convert.ToInt32(item);
                    puzzleInput.Add(val);                   
                    puzzleInput.Sort();
                }

                Console.WriteLine(GetExpenseReport(puzzleInput, 2, 2020));
                Console.WriteLine(GetExpenseReport(puzzleInput, 3, 2020));
            } catch (FormatException msg) {
                Console.WriteLine("{0} Input string is not a sequence of digits.", msg);
            }
            
        }

        /// <summary>
        /// Find x numbers in puzzle input that add up to the param myNum  
        /// <param name="puzzleInput">A list containing numbers</param>
        /// <param name="numToMltpl">An integer greater than 0. This is the number of integers that need to be found in the input</param>
        /// <param name="myNum">The number that should be the total of the sum</param>
        /// <returns>The product of the x numbers</returns>
        public static int GetExpenseReport(List<int> puzzleInput, int numToMltpl, int myNum) {
            // 
            Dictionary<int, List<int>> boxes = new Dictionary<int, List<int>>(); 
            
            int marker = myNum / numToMltpl;
            int markerRemainder = myNum % numToMltpl;
            Console.WriteLine("Division:{0}\nRemainder:{1}", 6/4, 6%4);
            
            for (int i = 0; i < numToMltpl; i++)
            {
                //boxes[0] = puzzleInput.
            }
            // if present then return result * item, else remove that item from the list
            foreach (int item in puzzleInput)
            {

                int numCompare = myNum - item;
                if (puzzleInput.Contains(numCompare)){
                    Console.WriteLine("Current item: {0}\nNumCompare: {1}", item, numCompare);
                    return item * numCompare;
                } 
            }

            return 0;
        }
    }
}
