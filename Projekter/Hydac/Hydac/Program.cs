class Guestbook
{

    static void Main(string[] args)
    {        
        bool running = true;
        bool first_run = true;
        Util utils = new Util();

        while (running)
        {
            if (first_run)
            {
                utils.getWelcomesText();
                first_run = false;
            }

            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("User ID:");
            string user_id = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Password:");
            string password = Console.ReadLine();

            if (utils.userExist(user_id, password) != true)
            {
                Console.WriteLine(
                    """
                    Login failed!

                    press enter to retry.

                    """);
                continue;
            }

            Console.Clear();

            Console.WriteLine(
                $"""
                Hello {user_id}

                choose an option:

                1. Find visitors
                2. End program
                
                """);            
        }          
    }
}
