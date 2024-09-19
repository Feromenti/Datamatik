namespace Hydac 
{
    public class Menu
    {
        public string Title;
        public int ItemCount;
        public MenuItem[] MenuItems;

        public Menu() {}
        public void Show()
        {
            Console.WriteLine(Title);
            Console.WriteLine(new string('-', Title.Length));

            for (int i = 0; i < ItemCount; i++)
            {
                Console.WriteLine(MenuItems[i].Title);
            }
        }
    }
}