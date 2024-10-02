namespace Hydac;

class MainProgram
{
    static void Main(string[] args)
    {
        string menuTitle = "Main Menu";
        Menu mainMenu = new Menu(menuTitle);

        string itemTitle = "Log in";
        mainMenu.AddMenuItem(itemTitle);        

        mainMenu.Show();
    }



}