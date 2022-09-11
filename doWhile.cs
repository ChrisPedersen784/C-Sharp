namespace DoWhile
{
    internal class Program
    {
        /*
         Creating a do while loop to keep asking the user for the correct input
         Guess a random number
         */
        static void Main(string[] args)
        {

            Console.WriteLine("Guess a random integer between 1 - 50");
            string input;

            int convertInput;
            Random randomNumber = new Random();
            int generateRandom = randomNumber.Next(1, 50);

    

            do
            {
                Console.Write("Input your guess: ");
                input = Console.ReadLine();

                if (!int.TryParse(input, out convertInput))//check for a valid integer 
                {
                    Console.WriteLine("Not a valid number");
                }else if(convertInput > generateRandom)
                {
                    Console.WriteLine("Too high, Try again");
                }else if(convertInput < generateRandom)
                {
                    Console.WriteLine("Too low, Try again");
                }


            } while (convertInput != generateRandom); //While convertInput is NOT equal generateRandom Keep running the code

            Console.WriteLine("You guessed my secret number ");


            Console.ReadLine();
        }
    }
}