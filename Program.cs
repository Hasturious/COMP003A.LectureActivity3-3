//Author: Jean Bryant Figueroa
//Course: COMP-003A
//Facualty: Johnathan Cruz
//Purpose: Advanced Control Statements

using System.ComponentModel.DataAnnotations;

namespace COMP003A.LectureActivity3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Advanced Control Statements Demo!");

            int range; //the range to iterate through

            while(true)
            {
                //try block
                try
                {
                    Console.Write("Enter a positive interger to iterate through: ");
                    range = int.Parse(Console.ReadLine());
                    if (range <= 0) throw new Exception("Number not positive.");
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Invalid Input: {ex.Message}\nPlease try again\n");
                }
            }
            
            Console.Write("Would you like to skip a number? (yes/no): ");
            string skipResponse = Console.ReadLine().ToLower();
            int skipNumber = 0;
            if (skipResponse == "yes")
                {
                    Console.Write("Enter the number to skip: ");
                    skipNumber = int.Parse(Console.ReadLine());
                }

            Console.Write("Would you like to terminate the loop at a specific number? (yes/no): ");
            string terminateResponse = Console.ReadLine().ToLower();
            int terminateNumber = 0;
            if (terminateResponse == "yes")
            {
                Console.Write("Enter termination number: ");
                terminateNumber = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nOutput:");
            for (int i = 0; i < range; i++)
            {
                if (i == skipNumber)
                {
                    continue;
                }
                if (i == terminateNumber)
                {
                    Console.WriteLine($"Loop Terminated at number {terminateNumber}.");
                    break; 
                }
                Console.WriteLine(i);
            }
            Console.Write("Enter 'restart' to try again or any other key to exit: ");
            string restart = Console.ReadLine().ToLower();
            if (restart == "restart")
            {
                goto Restart;
            }
            else
            {
                System.Environment.Exit(0);
            }
        Restart:
            Console.WriteLine("Restarting the program...\n");
            Main(args);
        }
    }
}
