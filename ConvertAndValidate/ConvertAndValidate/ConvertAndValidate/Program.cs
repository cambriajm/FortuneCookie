namespace ConvertAndValidate
//Cambria Morgan
//Spring 2026
//RCET 2265 
//https://github.com/cambriajm/ConvertAndValidate.git
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string userInput = "";

            do // do this until while is fufilled 
            {

                Console.WriteLine("Enter a number please\n" +
                    "or press q to quit, c to clear");
                userInput = Console.ReadLine(); 

                if (ConvertToInt(userInput, out int userOutput)) //based on input from user, does diff things
                {
                    Console.WriteLine($"Great! {userOutput} is a number");
                }
                else 
                {
                    Console.WriteLine($"Uhhhh... {userInput} was not a number, try again");
                }
                if(userInput == "C" || userInput == "c")
                {
                    Console.WriteLine("Okay! Console Clearing, press enter");
                    Console.Read();
                    Console.Clear();
                    Console.Read();
                }

            } while (userInput != "Q" && userInput != "q");

            Console.Clear();
            Console.WriteLine("Adios brochacho!");
            //pause 
            Console.Read();

        }
        static bool ConvertToInt(string input, out int result)//convert number method
        {
            
            bool successful = true;
            result = 0;
            //otu requires an argument no matter what
             
            try
            {
                 result = Convert.ToInt32(input);
                return true;
            }

            catch//if not a number it will show this false to the main 
            {
                result = 0;
                return false;
            }

            
        }
    }
}
        


