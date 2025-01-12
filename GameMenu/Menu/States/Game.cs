namespace Globals.Menu.States {
    internal class Game : IState {
        
        public IState? HandleInput(string input) {
            switch(input) {
                case MenuCommands.EXIT: {
                        return new MainMenu();
                    }
            }
            return null;
        }

        public void Render() {
            Console.WriteLine("***************");
            Console.WriteLine("****In Game****");
            Console.WriteLine("***************");
            Console.WriteLine($"Avalible commands ['{Globals.MenuCommands.EXIT}']");
        }
    }
}
