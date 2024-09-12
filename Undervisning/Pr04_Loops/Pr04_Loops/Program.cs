using System;

class Program
{
    static void Main(string[] args)
    {

        string userInput = "";

        Console.WriteLine(""" 

        Choose a number between 1-6

        Tasks from 11.09

        1: Task 3.1
        2: Task 3.2/3.3
        3: Task 4.1


        Tasks from 12.09

        4: Task 2.4
        5: Task 2.5
        6: Task 2.6


        Choose wisely :)



        """);

        int choise = int.Parse(Console.ReadLine());

        switch (choise)
        {

            case 1:

                while (userInput.ToLower() != "done")
                {

                    // spørger efter breden
                    Console.WriteLine("Input width");
                    double width = Convert.ToDouble(Console.ReadLine());

                    // spørger efter længten
                    Console.WriteLine("Input length");
                    double length = Convert.ToDouble(Console.ReadLine());

                    //giver arealet ud til consolen
                    Console.WriteLine("your answer is:\n" + (width * length));

                    // giver mulighed til afslute med opgaven eller gentage den
                    Console.WriteLine("""


                     Write 'done' if you´re done
                     else press enter
                     
                     """);

                    userInput = Console.ReadLine();

                }

                userInput = "";

                break;
            case 2:

                while (userInput.ToLower() != "done")
                {

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

                    // giver mulighed til afslute med opgaven eller gentage den
                    Console.WriteLine("""


                     Write 'done' if you´re done
                     else press enter
                     
                     """);

                    userInput = Console.ReadLine();

                }

                

                break;


            case 3:


                while (userInput.ToLower() != "done")
                {



                    //indlæser stringen
                    Console.WriteLine("\nWrite a Random sentence");
                    string userString = Console.ReadLine();

                    //udgiver string længde
                    Console.WriteLine("\nyou string has a lenght of:\n");
                    Console.WriteLine(userString.Length);

                    // giver mulighed til afslute med opgaven eller gentage den
                    Console.WriteLine("""


                     Write 'done' if you´re done
                     else press enter
                     
                     """);
                    userInput = Console.ReadLine();
                }

                userInput = "";

                break;



            case 4:

                while (userInput != "done")
                {
                    Console.WriteLine("""

                    write a sentence of your choise

                    """);

                    string userString = Console.ReadLine();

                    Console.WriteLine("""
                    
                    choose two indexes
                    
                    """);

                    string[] userChoise = Console.ReadLine().Split(',');

                    int choise1 = int.Parse(userChoise[0].Trim());
                    int choise2 = int.Parse(userChoise[1].Trim());


                    Console.WriteLine($"""

                    This is your first char  {userString[choise1 - 1]} 
                
                    This is your second char {userString[choise2 - 1]}
                
                    """);

                    // giver mulighed til afslute med opgaven eller gentage den
                    Console.WriteLine("""


                     Write 'done' if you´re done
                     else press enter
                     
                     """);

                    userInput = Console.ReadLine();
                }

                    

                    break;

                

            case 5:

                int count = 0;

                Console.WriteLine("""

                    Write a random string

                    """);
                string randomString = Console.ReadLine();

                while (count < randomString.Length)
                {

                    Console.WriteLine(count + " = " + randomString[count]);

                    count++;
                }

                // giver mulighed til afslute med opgaven eller gentage den
                Console.WriteLine("""


                     Write 'done' if you´re done
                     else press enter
                     
                     """);

                userInput = Console.ReadLine();

                break;


            case 6:

                int count2 = 0;

                Console.WriteLine("""

                    Write a random string

                    """);

                string randomString2 = Console.ReadLine();


                do
                {

                    Console.WriteLine(count2 + " = " + randomString2[count2]);
                    count2++;

                } while (count2! < randomString2.Length);

                // giver mulighed til afslute med opgaven eller gentage den
                Console.WriteLine("""


                     Write 'done' if you´re done
                     else press enter
                     
                     """);

                userInput = Console.ReadLine();


                break;






            case 7:




                break;







        }



    }
} 
