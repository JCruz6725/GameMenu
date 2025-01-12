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
            Console.WriteLine(
                Globals.MenuCommands.MenuString(
                    "In-Game"
                    ));


            Console.WriteLine(Globals.MenuCommands.CommandsListHelper([
                Globals.MenuCommands.EXIT
                ]));
        }
    }
}
