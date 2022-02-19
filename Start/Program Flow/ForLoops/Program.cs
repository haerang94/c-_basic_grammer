using System;

namespace ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int myVal = 15;
            int[] nums = new int[] {3, 14, 15, 92, 6};
            string str = "The quick brown fox jumps over the lazy dog";

            // TODO: the basic for loop
            Console.WriteLine("The basic for loop:");
            for(int i=0;i<nums.Length;i++){
                Console.WriteLine("i is currently {0}, value is {1}",i,nums[i]);
            }

            Console.WriteLine();

            // TODO: the foreach-in loop can be used to iterate over sequences
            Console.WriteLine("The foreach loop:");
            foreach(int i in nums){
                Console.WriteLine(i);
            }


            // TODO: count the number of o's in the string
            var cnt=0;
            foreach(char c in str){
                if(c=='o'){
                    cnt++;
                }
            }
            Console.WriteLine("counted {0} o characters",cnt);

        }
    }
}
