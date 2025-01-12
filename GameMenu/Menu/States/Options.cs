namespace Globals.Menu.States {
    internal class Options : IState {

        public IState? HandleInput(string input) {
            switch(input) {
                case Globals.MenuCommands.MAIN_MENU: {
                        //move back up.
                        return new MainMenu();
                    }
                case Globals.MenuCommands.DIFFICULTY: {
                        return new DifficultyMenu();
                    }
            }
            return null;
        }

        public void Render() {
            Console.WriteLine("*****************");
            Console.WriteLine("****Options******");
            Console.WriteLine("*****************");
            Console.WriteLine($"Avalible commands ['{Globals.MenuCommands.MAIN_MENU}, {Globals.MenuCommands.DIFFICULTY}']");

        }
    }
}
