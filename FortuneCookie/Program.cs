namespace FortuneCookie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a fortune cookie." +
                "\nUnfortunately, theres no actual cookies involved." +
                "\nI like snickerdoodle cookies." +
                "\nAnyways, heres your fortune." +
                "\n" +
                "\n");
            Random rand = new Random(); // constructor

            //test randomness and range with a for loop
            for (int i = 0; i < 1;)
            {
                //rand.Next(min, max) max is not inclusive 
                int n = rand.Next(1, 11); //random number between one and six

                while(true)
                {

                switch (n)
                {
                    case 0:
                        Console.WriteLine("You might want to check your engine oil :)");
                        break; 

                    case 1:
                        Console.WriteLine("yeehaw");
                        break;

                    case 2:
                        Console.WriteLine("no");
                        break;

                    case 3:
                        Console.WriteLine("AAAAA");
                        break;

                    case 4:
                        Console.WriteLine("b");
                        break;

                    case 5:
                        Console.WriteLine("bb");
                        break;

                    case 6:
                        Console.WriteLine("c");
                        break;

                    case 7:
                        Console.WriteLine("d");
                        break;

                    case 8:
                        Console.WriteLine("yedehaw");
                        break;
                }
                    Console.WriteLine("Would you like a new fortune?");
                    string userInput = "";
                    Console.ReadLine();
                   
                    if(userInput == "Yes" || userInput == "yes")
                    {

                    }
                    if (userInput == "No" || userInput == "no")
                    {
                        Console.WriteLine("Have a good day :)");
                    }
                    
                }
            }
            //pause
            Console.Read();
        }

    }
}