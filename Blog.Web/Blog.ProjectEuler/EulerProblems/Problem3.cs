using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.ProjectEuler.EulerProblems
{
    public class Problem3
    {
        //What tripped me up is the usage of the Modulus Operator (%). Once I found another way to use it, the rest was easy.
        //I am highly aware that this can be written in just a few lines and will go back and rework it.
        
        public static long LgPrimeFactor()
        {
            //Largest Prime Factor
            //The prime factors of 13195 are 5, 7, 13 and 29. What is the largest prime factor of the number 600851475143?

            //Prime factor means... 
            // (1) The number (x) is odd
            // (2) 600851475143 /x has remainder of 0 
            // (3) x is only divisible by itself and 1.

            long lgPrimeFactor = 0;

            const long myLongNumber = 600851475143;

            for (long i = 2; i < myLongNumber; i++)
            {
                long remainder = FindRemainder(i);
                if ( (IsZeroRemainder(remainder) == true) && (isPrime(remainder) == true) )
                {
                    lgPrimeFactor = remainder;
                }
            }
            return lgPrimeFactor;

        }
        //This method will be used to find the remaindar; we will later check to see if it is 0 or not. If 0, then y is a factor of the constant.
        public static long FindRemainder(long i)
        {
            const long x = 600851475143;
            long remainder;

            remainder = x % i;

            return remainder;
        }
        //This method will test to see if the remainder is 0.
        public static bool IsZeroRemainder(long remainder)
        {
            if (remainder == 0) return true;
            else return false;
        }

        public static bool isPrime(long n)
        {
            if ((n % 2 == 0 && n != 2) || (n % 3 == 0 && n != 3) || (n % 5 == 0 && n != 5))
                return false;
            for (long i = 5; i < n / 5; i += 2)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
    }
}