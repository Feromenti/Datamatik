﻿using System;
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
               ____    ____  _______  __       __  ___   ______   .___  ___. .___  ___.  _______ .__   __.                  
               \   \  /   / |   ____||  |     |  |/  /  /  __  \  |   \/   | |   \/   | |   ____||  \ |  |                  
                \   \/   /  |  |__   |  |     |  '  /  |  |  |  | |  \  /  | |  \  /  | |  |__   |   \|  |                  
                 \      /   |   __|  |  |     |    <   |  |  |  | |  |\/|  | |  |\/|  | |   __|  |  . `  |                  
                  \    /    |  |____ |  `----.|  .  \  |  `--'  | |  |  |  | |  |  |  | |  |____ |  |\   |                  
                   \__/     |_______||_______||__|\__\  \______/  |__|  |__| |__|  |__| |_______||__| \__|                  
                                             .___________.__   __                                                           
                                             |           |  | |  |                                                          
                                             `---|  |----|  | |  |                                                          
                                                 |  |    |  | |  |                                                          
                                                 |  |    |  | |  `----.                                                     
                                                 |__|    |__| |_______|                                                     
                               __    __  ____    ____  _______       ___       ______                                       
                              |  |  |  | \   \  /   / |       \     /   \     /      |                                      
                              |  |__|  |  \   \/   /  |  .--.  |   /  ^  \   |  ,----'                                      
                              |   __   |   \_    _/   |  |  |  |  /  /_\  \  |  |                                           
                              |  |  |  |     |  |     |  '--'  | /  _____  \ |  `----.                                      
                              |__|  |__|     |__|     |_______/ /__/     \__\ \______|    
                              
            .______   .______      _______     _______.     _______.    _______ .__   __. .___________._______ .______      
            |   _  \  |   _  \    |   ____|   /       |    /       |   |   ____||  \ |  | |           |   ____||   _  \     
            |  |_)  | |  |_)  |   |  |__     |   (----`   |   (----`   |  |__   |   \|  | `---|  |----|  |__   |  |_)  |    
            |   ___/  |      /    |   __|     \   \        \   \       |   __|  |  . `  |     |  |    |   __|  |      /     
            |  |      |  |\  \----|  |____.----)   |   .----)   |      |  |____ |  |\   |     |  |    |  |____ |  |\  \----.
            | _|      | _| `._____|_______|_______/    |_______/       |_______||__| \__|     |__|    |_______|| _| `._____|
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   
            """);    
    }
}
