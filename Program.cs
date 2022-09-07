namespace Programming02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Brugeren skal kunne indtaste sit navn og alder via konsolvinduet
            og gemme oplysningerne i henholdsvis en string og int variabel (husk konvertering). 
            Genbrug kode fra tidligere øvelse.
             */

            /*
             De indtastede oplysninger udskrives til konsolvinduet sammen med en angivelse, om man er et barn, teenager etc. ud fra den indtastede alder med følgende forslag til en aldersinddeling og -beskrivelse:
            0-12:   ”et barn”
            13-19: ”en teenager”
            20-25: ”en studerende”      
            26-67: ” i arbejde”
            > 67:    ”en pensionist”
             */


            Console.WriteLine("Indtast navn");
            string navn = Console.ReadLine();
            Console.WriteLine("Hej " + navn);

            Console.WriteLine("Indtast alder: ");
            string nyAlder = Console.ReadLine();
            int alder = int.Parse(nyAlder);

            if (alder <= 12 && alder >= 0)
            {
                Console.WriteLine("Et barn");
            } else if (alder >= 13 && alder <= 19)
            {
                Console.WriteLine("en teenager");
            } else if (alder >= 20 && alder <= 25)
            {
                Console.WriteLine("En studerende");
            } else if (alder >= 26 && alder <= 67)
            {
                Console.WriteLine("En i arbejde");

            } else if (alder >= 67)
            {
                Console.WriteLine("En pensionist");

            }else
            {
                Console.WriteLine("Du har indtastet en ugyldig alder");
            }



            Console.WriteLine("Din alder er: " + alder);


            
            


            Console.ReadLine(); 
        }
    }
}