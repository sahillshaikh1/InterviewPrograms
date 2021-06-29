using ImTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestion
{

    class Program
    {
      
        
        static void Main(string[] args)
        {
            //  Reverse("Sahil");
            //   Factorial(4);
            //  Arsmtrong(153);
            //  StringPalindrome("sahil");
            // PalindromeNumber();
            // CheckArray();
            // Patterns();
            //  PatternOne();
            // PatternTwoSpace();
           // Pyramid();

        }

      
        #region ReverseString
        public static void  Reverse(string input)
        {
            char[] rev = input.ToCharArray();
            for (int i = rev.Length-1; i >= 0; i--)
            {
                Console.Write(rev[i]);
            }
          
            Console.ReadLine();

           
        }
        #endregion

        #region factorial
        public static int fact = 1;
        public static void Factorial(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                fact = fact *i;
               
            }
            Console.Write(fact);
            Console.ReadLine();
           
        }
        #endregion

        #region ArmStrong
       
      static  int rem;
      static  int cube;
      static  int result;
        static int temp;
        public static void Arsmtrong(int number)
        {
            temp = number;
            while (number != 0)
            {
                rem = number % 10;
                cube = rem * rem * rem;
              
                number = number / 10;
                result = result + cube;
            }
            number = temp;
            if(number == result)
            {
                Console.Write("Number is Armstrong");
            }
            else
            {
                Console.Write("Number is not an Armstrong");

            }
            Console.ReadLine();
        }



        #endregion

        #region Palindrome
        //String
       static int Result,remender,Check;
       static int number = 121;
        public static void StringPalindrome(string input)
        {
            string rev="" ;
            for (int i = input.Length-1; i >= 0; i--)
            {
                rev += input[i].ToString();
                Console.WriteLine(rev);
            }
           if(input == rev)
            {
                Console.WriteLine("Is Palindrome");
            }
            else
            {
                Console.WriteLine("Is not Palindrome");
            }

            Console.ReadLine();
        }

        public static void PalindromeNumber()
        {
            Check = number;
            while (number > 0)
            {
                remender = number % 10;
                Result = Result * 10 + remender;
                number = number / 10;
                
            }
            number = Check;
            if(Result == number)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("not Palindrome");
            }
            Console.ReadLine();

        }




        #endregion

        #region ArrayMaxAndMIN

      static  int[] Array = new int[] { 0, 7, 6, 4, 20, 9, 90, 2 };
       static int max = Array[0];
       static int min = Array[0];
        static int SecondMax ;
        static int SecondMin;
        public static void CheckArray()
        {
            for (int i = 0; i < Array.Length; i++)
            {
                if(max< Array[i])
                {
                    SecondMax = max;
                    max = Array[i];
                   
                }
               else if(SecondMax < Array[i])
                {
                    SecondMax = Array[i];
                }
               
                if (min > Array[i])
                {
                    SecondMin = min;
                    min = Array[i];
                   
                }
                //else if(SecondMin > Array[i] && min != Array[i]) // second Mini not working
                //{
                //    SecondMin = Array[i];
                //}

            }
            Console.WriteLine(max + " :Max integer in Array " + min + " :Min integer in Array " + SecondMax + " Second Max Number ");// + SecondMin + " Second Min Number ");
            Console.ReadLine();
        }


        #endregion

        #region Patterns

        public static void Patterns()
        { 
        
            for (int i = 0; i<=5; i++)
			{
                for (int j = 1; j<= i; j++) // j=i ;j<=5 to rotate
			    {
                    Console.Write("*");
			    }
              Console.WriteLine();

			}
            Console.ReadLine();
        }
        public static void PatternOne()
        {

            for (int i = 0; i <= 5; i++)
            {
                for (int j = i; j <= 5; j++)
                {
                    Console.Write(i);/// replace i to j
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        public static void PatternTwoSpace()
        {
            for (int i = 0; i <= 5; i++)
            {
                for (int j = i; j <=5; j++)// to reverse  j=2 ;j<=i
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <=i; k++)//k=i k<=5
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        public static void Pyramid()
        {
            int count = 0;
            for (int i = 0; i <= 5; i++)
            {
                for (int j = i; j <= 5; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++) // k<= 2*i-1  for without Thirdloop
                {
                    Console.Write("*");
                }
                for (int l = 2; l <= i; l++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }
            Console.ReadLine();
        }



        #endregion





    }
}
