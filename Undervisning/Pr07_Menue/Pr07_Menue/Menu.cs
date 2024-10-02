namespace Hydac;

public class Menu
{
    public string Title;    
    private MenuItem[] MenuItems;
    private int ItemCount = 0;

    // Det her er en constructor
    public Menu(string menuTitle) 
    {   
        Title = menuTitle;
        MenuItems = new MenuItem[10];
        MenuItem[] menuItems = MenuItems;
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

    public int SelectMenuItem()
    {
        bool running = true;
        while (running)
        {
            int input = int.Parse(Console.ReadLine());        

                if (input <= ItemCount && input != 0)
                {
                    return input;                    
                }
            running = false; 
        }
        return 0;
    }
}
