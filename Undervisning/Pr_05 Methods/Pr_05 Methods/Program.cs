using System.Numerics;

class Programm
{
    static void Main(string[] args)
    {
        bool running = true;        
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

            if ( Console.ReadLine() == "1")
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

            var calc = new Calculator().calculation(x, a, y);

            Console.Clear();

            Console.WriteLine(
                $"""

                The answer is {calc}

                """);

            Console.WriteLine(
                """

                Are you done?

                Write 'done' if you´re done
                else press any button to continue.
                
                """);

            if (Console.ReadLine() == "done")
            {
                running = false;                
            }

            Console.Clear();
        }
    }        
}

public class Calculator
{
    public double calculation(double x, char a, double y)
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