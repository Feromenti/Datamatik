using System;
using System.Globalization;

public class Util
{
    string[,] login_data = 
        {
        { "JohnJ", "123456" },
        { "user2", "123456"}
        };

    string[,] guest_book =
        {
        {"Julien","Microsoft","Medium","18.09.24","13.30-15.30" },
        {"","","","","" },
        {"","","","","" }
        };
    public bool userConfirmation(char y)
	{
		if (Console.ReadLine() == "y")
		{ 
			return true;
		}
		return false;	
	}
    public bool userExist(string a, string b)
    {        
        for (int i = 0; i < login_data.GetLength(0); i++)
        {            
            if (a == login_data[i, 0] && b == login_data[i, 1])
            {
                return true;
            }
        }
        return false;
    }
    public void getWelcomesText()
    {
        Console.WriteLine(
            """                                                                            
             _____       _            _____             _   _           _   
            |  |  |_ _ _| |___ ___   |   __|_ _ ___ ___| |_| |_ ___ ___| |_ 
            |     | | | . | .'|  _|  |  |  | | | -_|_ -|  _| . | . | . | '_|
            |__|__|_  |___|__,|___|  |_____|___|___|___|_| |___|___|___|_,_|
                  |___|                                                     







                     _____                    _____     _                           
                    |  _  |___ ___ ___ ___   |   __|___| |_ ___ ___                 
                    |   __|  _| -_|_ -|_ -|  |   __|   |  _| -_|  _|                
                    |__|  |_| |___|___|___|  |_____|_|_|_| |___|_|                  


                     _____                    _   _                                 
                    |_   _|___    ___ ___ ___| |_|_|___ _ _ ___                     
                      | | | . |  |  _| . |   |  _| |   | | | -_|                    
                      |_| |___|  |___|___|_|_|_| |_|_|_|___|___|                    
                                                                                                                                                                                                                                                                               
            """);    
    }
}
