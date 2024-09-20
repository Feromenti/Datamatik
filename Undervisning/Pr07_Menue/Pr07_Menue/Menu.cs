namespace Hydac;

public class Menu
{
    public string Title;
    private int ItemCount = 0;
    private MenuItem[] MenuItems = new MenuItem[25];

    // Det her er en constructor
    public Menu(string menuTitle) 
    {   
        Title = menuTitle;        
    }
    public void Show()
    {
        Console.WriteLine(Title);
        Console.WriteLine(new string('-', Title.Length));

        for (int i = 0; i < ItemCount; i++)
        {
            if (MenuItems[i] != null)
            {
                Console.WriteLine($" {i+1}: {MenuItems[i].Title}");
            }
        }
    }

    public void AddMenuItem(string itemTitle)
    {       
        MenuItem mi = new MenuItem(itemTitle);       
        MenuItems[ItemCount] = mi;
        ItemCount++;
    }

    public string SelectMenuItem(int i)
    {
        
        switch (i)
        {
            case 1:
                string menuItem = "Gøt dit";
                return menuItem;
            case 2:
                string menuItem2 = "Gør dat";
                return menuItem2;
            case 3:
                string menuItem3 = "Gør noget";
                return menuItem3;
            case 4:
                string menuItem4 = "Få svaret på livet, universet og alting";
                return menuItem4;

            default:
                return "";




        }

    }
}
