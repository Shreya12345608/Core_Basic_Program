using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Basic Core Program");
            Console.WriteLine("Enter your choice between 1 to 10: ");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("1 For: Flip a Coin Head and Tail. ");
            Console.WriteLine("2 For: Select Value is Leap Year Or not");
            Console.WriteLine("3 For: Select Power of 2 Number");
            Console.WriteLine("4 For: Select the Harmonic Number");
            Console.WriteLine("5 For: Select Factors of number");
            Console.WriteLine("6 For: Select Quotient and Remainder");
            Console.WriteLine("7 For: Select Swap the Numbers");
            Console.WriteLine("8:Select Even and Odd number");
            int selection = Convert.ToInt32(Console.ReadLine());
           
            // user selection

            switch (selection)
            {
                case 1:
                    //FLIP COIN
                    FlipCoinHeadOrTail FlipCoin = new FlipCoinHeadOrTail();
                    FlipCoin.CheckHeadTailPercentage();
                    break;
                case 2:
                    //CheckLeapYearOrNot
                    CheckLeapYearOrNot LeapYearOrNot = new CheckLeapYearOrNot();
                    LeapYearOrNot.LeapYear();
                    break;
                case 3:
                    //Power Of 2
                    CalculatePowerOf2 CalPower = new CalculatePowerOf2();
                    CalPower.CalcuOfPower();
                    break;
                case 4:
                    //Harmonic Series
                    HarmonicNumber CalculateHarmonicNumber = new HarmonicNumber();
                    CalculateHarmonicNumber.CalcHarmonicSeries();
                    break;
                case 5:
                    //Prime Factor
                    PrimeFactorization PrimeFactor = new PrimeFactorization();
                    PrimeFactor.CalcSFactorialSeries();
                    break;
                case 6:
                    //Prime Factor
                    QusRemaindercs QuesRem = new QusRemaindercs();
                    QuesRem.QuotientRemainder();
                    break;
                case 7:
                    //Swap 2 number
                    Swap2Number SwapTwoNo = new Swap2Number();
                    SwapTwoNo.SwapTwoNumber();
                    break;
                case 8:
                    // Even Or odd
                    EvenOrOdd EvenOdd = new EvenOrOdd();
                    EvenOdd.CheckEvenOrdd();
                    break;
                default:
                    Console.WriteLine("Invalid Selection. Select inBetween 1 to 7");
                    break;
            }
            Console.ReadLine();
        }
    }
}
