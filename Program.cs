namespace LommeRegner
{
    internal class Program
    {


        static void Main(string[] args)
        {

            LommeRegner l = new LommeRegner();

            bool runProgram = true;
            do
            {
            Console.WriteLine("Vælg et regnestykke format:");
            Console.WriteLine("tryk 1 for: Add");
            Console.WriteLine("tryk 2 for: Substract");
            Console.WriteLine("tryk 3 for: Divide");
            Console.WriteLine("tryk 4 for: Multiply");
            Console.WriteLine("tryk 0 for at lukke programmet");
              
            string input = Console.ReadLine().ToLower();
            if(input == "1" || input == "2" || input == "3" || input == "4" || input == "0")
                {

            if(input == "0")
                {
                    runProgram = false;
                    Console.WriteLine("GoodBye....");
                    break;
                }else
                {
                    runProgram = true;  
                }

            Console.WriteLine("Indtast dit første tal");
            double input1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Indtast dit første tal");
            double input2 = double.Parse(Console.ReadLine());

                if(input == "1")
                {
                double addResult = l.Add(input1,input2);
                Console.WriteLine("Result " + addResult);

                }else if(input == "2")
                {
                    double subResult = l.Substract(input1, input2);
                    Console.WriteLine("Result " + subResult);
                }
                else if (input == "3")
                {
                    double divResult = l.Divide(input1, input2);
                    Console.WriteLine("Result " + divResult);
                }
                else if(input == "4")
                {
                    double multiResult = l.Multiply(input1, input2);
                    Console.WriteLine("Result " + multiResult);
                }
                } 
                else
                {
                    Console.WriteLine("Not a valid input");
                }

                
            }while(runProgram);

            Console.ReadLine();
        }
    }
}