using Globals.Menu.States;

namespace Globals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var MainContext = new Menu.MenuContext(new MainMenu());
            MainContext.Render();
            while(true) { 
                MainContext.Execute(Console.ReadLine());
            }
        }
    }
}
