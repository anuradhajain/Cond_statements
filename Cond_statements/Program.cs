using System;

namespace Cond_statements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your age:");
            try
            {
                // taking user input
                string input = Console.ReadLine(); // takes user input
                int age = int.Parse(input); // converts user input to int and stores it in memory in variable age 

                // Conditional statements to ask questions according to age 
                if (age < 18)
                {
                    Console.WriteLine("You are a Minor");
                    Console.WriteLine("Which is your favourite toy?");
                    string question = Console.ReadLine();
                    Console.WriteLine("So your favourite toy is " + question + ". Thats cool!");


                    // Switch case is used to write further conditional statements
                    switch(question)
                    { 
                   
                        case "ball":
                            Console.WriteLine("So, you are a sports guy!");
                            break;

                        case "doll":
                            Console.WriteLine("That's cute!");
                            break;
                            
                        default:
                            Console.WriteLine("So, there is no ball or doll");
                            break;


                    } // end of switch

                } // end of if(age < 18)
                else if (age > 18 && age < 65)
                {
                    Console.WriteLine("You are an Adult");
                    Console.WriteLine("Which is your favourite movie?");
                    string question = Console.ReadLine();                    
                    Console.WriteLine("So your favourite movie is " + question + ". Thats cool!");

                } //end of(age > 18 && age < 65)
                else
                {
                    Console.WriteLine("You are a Senior");
                    Console.WriteLine("Which is your favourite book?");
                    string question = Console.ReadLine();            
                    Console.WriteLine("So your favourite book is " + question + ". Thats cool!");

                } // end of else

                Console.WriteLine("Press any key to exit application");
                Console.ReadKey(true);

            } // end of try

            catch
            {
                Console.WriteLine("You have an error");
                Console.WriteLine("Press any key to exit application");
                Console.ReadKey(true);

            } // end of catch

        } // end of main
    } // end of class
} // end of namespace
