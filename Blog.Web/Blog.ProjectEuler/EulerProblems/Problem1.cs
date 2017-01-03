﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.ProjectEuler
{
    public class Problem1
    {
        public static int multiplesOf3and5()
        {
            //Multiples of 3 and 5
            //If we list all the natural numbers below 10 that are multiples of 3 or 5, 
            //we get 3, 5, 6 and 9. The sum of these multiples is 23.
            //Find the sum of all the multiples of 3 or 5 below 1000.
            int sum = 0;

            for (int i = 0; i<1000; i++)
			    {
                    if(i % 3==0 || i % 5 == 0)
                    {
                        sum += i;
                    }   
			    }

            return sum;
        }
    }
}

