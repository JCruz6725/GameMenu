namespace Globals.Menu.States {
    internal class Options : IState {

        public IState? HandleInput(string input) {
            switch(input) {
                case Globals.MenuCommands.DIFFICULTY: {
                        return new DifficultyMenu();
                    }
                case Globals.MenuCommands.EXIT: {
                        //move back up.
                        return new MainMenu();
                    }
            }
            return null;
        }

        public void Render() {
            Console.WriteLine("*****************");
            Console.WriteLine("****Options******");
            Console.WriteLine("*****************");
            Console.WriteLine($"Avalible commands ['{Globals.MenuCommands.DIFFICULTY}, {Globals.MenuCommands.EXIT}']");

        }
    }
}
