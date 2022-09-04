namespace KonsolApplikation
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("What is your full name? ");
            string fName;
            fName = Console.ReadLine();
            Console.WriteLine("Hello " + fName);

            string age;
            int newAge;

            do
            {
      
                Console.WriteLine("How old are you? ");
                //Reads user age and stores it into age
                age = Console.ReadLine();
                //Here we check again if age is an integer
                //if NOT true run the if statement!
                if(!int.TryParse(age, out newAge))
                {
                    Console.WriteLine("Enter valid number");
                }   

            } while (!int.TryParse(age, out newAge)); 
            //age = user input, 
            //newAge gets the valid integer save, so newAge holds the value

            /*
             The Do While loop will run as long as age is the user input a valid integer.
            AND keep looping if user inputs a string!!
             */
                                                      
            //This will run after the Do While Loop..
            Console.WriteLine("success");
            Console.WriteLine("You are " + newAge + " years old");
    

        }
    }
}