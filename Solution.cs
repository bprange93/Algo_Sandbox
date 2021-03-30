using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Test_2
{
    class Solution
    {
        public int solution(int[] A)
        {
            //instatiate N and give it the Max value(all of the numbers)
            int N = A.Max();

            //Simply if the number in it is less than 1 (0) then it will return 1 if that is the only number. 
            if (N < 1)
            {
                return 1;
            }
            //A.Length grabs all the elements in the array and if they equal 1 goes into if statment. 
            if(A.Length == 1)
            {
                //if at the first index (0) and equals 1 return 2, if not return 1. 
                if(A[0] == 1)
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }

            //instantiate i to be set to 0 to use it in the array as a set number of 0
            int i = 0;
            //instantiate new array l to bring in the Max values used earlier
            int[] l = new int[N];
            for(i = 0; i < A.Length; i++)
            {
                if( A[i] > 0)
                {
                    if(l[A[i] - 1] != 1)
                    {
                        l[A[i] - 1] = 1;
                    }
                }
                
            }
            for(i = 0; i < l.Length; i++)
            {
                if(l[i] == 0)
                {
                    return i + 1;
                }
            }
            //add 2 because numbers start at 0 in index not 1. 
            return i + 2;
        }

        public void runSolution()
        {
            int[] A = { 6, 1, 2, -10, -20, 3 };
            Console.WriteLine(solution(A));
            Console.ReadLine();
        }

        public void longEnoughMovies()
        {

        }
        

    }
}
