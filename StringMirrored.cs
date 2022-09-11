namespace programming01
{
    internal class Program
    {

        /*
         Mirror a string from a user input!
         */
        static void Main(string[] args)
        {

            Console.Write("Enter a word to be reversed: ");
            string input = Console.ReadLine();

            string reverse = "";

            Console.WriteLine(input + " " + input.Length + " " + reverse.Length);

            for (int i = input.Length -1; i > -1; i--)
            {
                reverse += input[i];
            }

                Console.Write(reverse);

            Console.ReadLine();
        }
    }
}