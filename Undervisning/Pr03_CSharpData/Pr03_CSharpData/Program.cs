
class Program 
{
   
    static void Main(string[] args)
    {
        string userInput = "";
        
        //opgave 3.1
        while (userInput.ToLower() != "done" )
        {   
            // giver mulighed hat skipe opgaven ( virker ikke ;/ )
            Console.WriteLine("Write 'done' to skip task\n" + "press any button to continue");
            userInput = Console.ReadLine();

            if (userInput == "done")
            {
                break;
            }
            // spørger efter breden
            Console.WriteLine("Input width");
            double width = Convert.ToDouble(Console.ReadLine());

            // spørger efter længten
            Console.WriteLine("Input length");
            double length = Convert.ToDouble(Console.ReadLine());

            //giver arealet ud til consolen
            Console.WriteLine("your answer is:\n" + (width * length));

            // spørger om du vil beregne et andet areal eller gå til næste opgave
            Console.WriteLine("\nWrite 'done' if you´re done");
            Console.WriteLine("else press enter\n");
            userInput = Console.ReadLine();
        
        }

        userInput = "";

        // opgave 3.2 / 3.3
        while (userInput.ToLower() != "done")
        {

            // giver mulighed hat skipe opgaven ( virker ikke ;/ )
            Console.WriteLine("Write 'done' to skip task\n" + "press any button to continue");
            userInput = Console.ReadLine();

            if (userInput == "done")
            {
                break;
            }

            //Laver et String array der gemmer det første tupel 
            Console.WriteLine("Enter the first tuple in the format: x1, y1:");
            string[] startPointInput = Console.ReadLine().Split(',');

            // parser string til double
            double x1 = Convert.ToDouble(startPointInput[0].Trim());
            double y1 = Convert.ToDouble(startPointInput[1].Trim());

            //Laver et String array der gemmer det andet tupel 
            Console.WriteLine("Enter the second tuple in the format: x2, y2:");
            string[] endPointInput = Console.ReadLine().Split(',');

            // parser string til double
            double x2 = Convert.ToDouble(endPointInput[0].Trim());
            double y2 = Convert.ToDouble(endPointInput[1].Trim());
             
            // beregner hældingen og giver den til consolen
            double slope = (y2 - y1) / (x2 - x1);
            Console.WriteLine($"The slope of the line segment is: {slope}");

            // giver mulighed til afslute med opgaven eller gentage regningen
            Console.WriteLine("\nWrite 'done' if you´re done");
            Console.WriteLine("else press enter\n");
            userInput = Console.ReadLine();

        }

        userInput = "";
        
        // opgave 4.1
        while (userInput.ToLower() != "done")
        {

            // giver mulighed hat skipe opgaven ( virker ikke ;/ )
            Console.WriteLine("Write 'done' to skip task\n" + "press any button to continue");
            userInput = Console.ReadLine();

            if (userInput == "done")
            {
                break;
            }

            //indlæser stringen
            Console.WriteLine("\nWrite a Random sentence");
            string randomString = Console.ReadLine();

            //udgiver string længde
            Console.WriteLine("\nyou string has a lenght of:\n");
            Console.WriteLine(randomString.Length);

            // giver mulighed til afslute med opgaven eller gentage regningen
            Console.WriteLine("\nWrite 'done' if you´re done");
            Console.WriteLine("else press enter\n");
            userInput = Console.ReadLine();
        }

    }
}