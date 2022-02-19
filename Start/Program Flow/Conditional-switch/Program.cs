using System;

namespace ConditionalOps
{
    class Program
    {
        static void Main(string[] args)
        {
            int theVal = 50;

            // TODO: The switch statement
            switch(theVal){
            case 50:
                    Console.WriteLine("theVal is 50.");
                    break;
            case 51:
            case 52:
            case 53:
                    Console.WriteLine("theval is between 51 and 53");
                    break;
            default:
                    Console.WriteLine("else statement");
                    break;
            }

        }
    }
}
