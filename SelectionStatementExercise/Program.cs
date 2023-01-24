using System.Threading.Channels;

namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Can you guess my favorite number???");
            FavoriteNumber();
        }

        static bool FavoriteNumber()
        {
            

            var r = new Random();
            var favNumber = r.Next(1, 10);
            var userInput = int.Parse(Console.ReadLine());

            if (userInput < favNumber)
            {
                Console.WriteLine("Too Low");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine("Too High");
            }
            
                
            if (userInput == favNumber)
                {
                    Console.WriteLine("You Got it");
                    return true;
                }
                else
                {
                    
                    return false;
                }
            
        }
        //var r = new Random();
        //var favNumber = r.Next(1,1000);
        //var userInput = int.Parse(Console.ReadLine());
    }
}
