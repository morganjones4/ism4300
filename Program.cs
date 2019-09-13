// Authour: Morgan Jones
//Date:9/11/2019
// Description: Creating an iteration with a loop.
using System;

namespace Deliverable_2___Iteration_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            // Asking the user for input 
            Console.WriteLine("Please enter an integer between 1 and 100!");

            // Using the try catch block to validate user input
            try
            {
                // This will gather the information from the user.
                string input = Console.ReadLine();
                // This will be used to perform the iteration statement
                int value_of_input = int.Parse(input);

                // Giving an IF/Else statement to the users input of 1-100
                if ((value_of_input > 0) && (value_of_input <= 100))
                {
                    Console.WriteLine("Executing a For Loop!");
                    Console.WriteLine("The For Loop will iterate" + value_of_input + "times.");
                    // The while loop
                    for (int i = 0; i < value_of_input; i++)
                    {
                        Console.WriteLine("The value of the varible i in this iteration is:" + i.ToString());
                    }

                    Console.WriteLine("Press any key to exit the program....");
                    // Wait for the user to make input.
                    Console.ReadKey(true);
                }

                while (value_of_input > 0)
                {
                    Console.WriteLine("The value of the iteration is:" + value_of_input.ToString());
                    value_of_input--;
                }
                Console.WriteLine("Press any key to exit!");
                Console.ReadKey(true);
            
                // If nothing works this is an alternative.
            else 
            {
                Console.WriteLine("Please enter an integer between 1 and 100!");
                Console.WriteLine("Press any key to exit the program.");
                Console.ReadKey(true);

            }
            


                // A catch phrase incase an integer isn't entered.
            catch
                {
                    Console.WriteLine("Please enter an integer between 1 and 100!");
                Console.WriteLine("Press any key to exit the program!");
                    Console.ReadKey(true);
                }


              

        }
    }
}
