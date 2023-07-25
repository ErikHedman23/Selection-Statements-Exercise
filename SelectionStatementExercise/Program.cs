namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number: any number...");


            var r = new Random();
            var favNumber = r.Next(1, 1000);
            var userInput = int.Parse(Console.ReadLine());//asking user for a number
            
            while (userInput != favNumber)
            {
            if (userInput < favNumber)//condition
            {
                Console.WriteLine("too low");//response
            }
            else if (userInput > favNumber)//condition
            {
                Console.WriteLine("too high");//response
            }
            else
            {
                Console.WriteLine("You guessed it!!!");//response
            }

            }

        }
    }
}
