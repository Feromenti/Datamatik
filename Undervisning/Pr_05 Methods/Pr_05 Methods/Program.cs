using System.Numerics;

class Programm
{
    static void Main(string[] args)
    {
        bool running = true;
        string userInput;
        bool firstStart = true;

        while (running)
        {
            if (firstStart)
            {
                Console.WriteLine(
                    """

                    Welcome to the best calculator in the world.
            
                    are you ready to start?

                    1 = end
                    any button to continue

                """);

                firstStart = false;
            }
            userInput = Console.ReadLine();

            if (userInput == "1")
            {
                running = false;
                continue;
            }

            Console.Clear();

            Console.WriteLine(
                """

                whats your math problem?

                possible operator ( +, -, *, /)

                """);           

            Console.WriteLine("""
                Input a value
                """);

            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(
                """

                Choose an operator:

                +, -, *, eller /

                """);
            char a = Convert.ToChar(Console.ReadLine());

            Console.WriteLine(
                """
                Input a value
                """);
            double y = Convert.ToDouble(Console.ReadLine());

            var calc = new calculator().Calculator(x, a, y);            

            Console.WriteLine(
                $"""

                The answer is {calc}

                """);

            Console.WriteLine(
                """

                Are you done?

                Write 'done' if you´re done
                else press any button.
                
                """);

            if (Console.ReadLine() == "done")
            {
                running = false;
            }

            Console.Clear();
        }
    }        
}

class calculator
{
    public double Calculator(double x, char a, double y)
    {
        switch (a)
        {
            case '+':
                return x + y;
            case '-':
                return x - y;
            case '*':
                return x * y;
            case '/':
                return x / y;
            default:
                return 0;
        }
    }
}