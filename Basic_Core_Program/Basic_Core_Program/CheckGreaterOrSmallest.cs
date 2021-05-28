using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Program
{
    class CheckGreaterOrSmallest
    {
        public int Number1;
        public int Number2;
        public int Number3;
        public void GreaterOrSmaller()
        {
            
            Console.Write("Input the 1st number :"); //input from user
            Number1 = Convert.ToInt32(Console.ReadLine()); //Read Number1
            Console.Write("Input the  2nd number :");//input from user
            Number2 = Convert.ToInt32(Console.ReadLine()); //Read Number2
            Console.Write("Input the 3rd  number :");//input from user
            Number3 = Convert.ToInt32(Console.ReadLine()); //Read Number3

            if (Number1 > Number2) //check if Number 1is graeder than number2
            {
                if (Number1 > Number3)  //check if Number 1 is graeder than number3
                    Console.Write("The 1st Number is the greatest among three. \n\n");
                else
                    Console.Write("The 3rd Number is the greatest among three. \n\n");
            }
            else if (Number2 > Number3)//check if Number 2 is graeder than number3
                Console.Write("The 2nd Number is the greatest among three. \n\n");
            else
                Console.Write("The 3rd Number is the greatest among three. \n\n");
        }
    }
}

