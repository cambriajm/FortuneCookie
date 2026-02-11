namespace FortuneCookie
//Cambria Morgan
//Spring 2026
//RCET 2265
//MultiplicationTable
//https://github.com/cambriajm/FortuneCookie.git
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
                int n = rand.Next(1, 11); //random number 

                

                switch (n)
                {
                    case 0:
                        Console.WriteLine("You might want to check your engine oil :)");
                        break; 

                    case 1:
                        Console.WriteLine("You WILL find that missing sock that the washer ate.");
                        break;

                    case 2:
                        Console.WriteLine("Your cat doesn't hate you, you're just insecure.");
                        break;

                    case 3:
                        Console.WriteLine("You will not be late to work.");
                        break;

                    case 4:
                        Console.WriteLine("This is a fortune cookie fortune. Yay!");
                        break;

                    case 5:
                        Console.WriteLine("Beware the beast (your cat is hungry).");
                        break;

                    case 6:
                        Console.WriteLine("You will go to bed early tonight.");
                        break;

                    case 7:
                        Console.WriteLine("Pretend this is like, some motivational fortune.");
                        break;

                    case 8:
                        Console.WriteLine("For a better fortune, eat another cookie.");
                        break;
                }
                   
            //pause
            Console.Read();
                    
                }
            }
        }

    }
