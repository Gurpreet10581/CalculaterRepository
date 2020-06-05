using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaterRepository
{
    public class Calculator_Repo
    {
        
        //Calculator w/ Tests Challenge
        //Create a Calculator class that has the ability to complete all of the following processes:
        //Add
        //Subtract
        ///Multiply
        ///Divide
        ///Write Unit Tests for all of your calculator's functionalities.

        ///Bonus Challenges:

       ///Allow use of whole numbers and numbers with decimals
       ///Have the ability to return fractions instead of percentages
       ///Allow the calculator to take in as many numbers as the user provides
       
        // step create methods
        //int

        public int AddNamers(int numOne, int numTow)
        {
            int sum = numOne + numTow;

            return sum;
        }
  
       

        public decimal DivideNumbers(decimal numOne, decimal numTwo)
        {
            decimal sum = numOne / numTwo;

            return sum;

        }

        public int Subtract(int numOne, int numTwo)
        {
            int sum = numOne - numTwo;
            return sum;
        }

        public decimal Multiply(decimal numOne, decimal numTwo)
        {
            decimal sum = numOne * numTwo;

            return sum;
        }
    }
}
