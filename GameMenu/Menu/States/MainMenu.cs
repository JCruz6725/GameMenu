namespace Globals.Menu.States {
    internal class MainMenu : IState {

        public IState? HandleInput(string input) {
            switch(input) {
                case Globals.MenuCommands.PLAY_GAME: {
                        return new Game();
                    }
                case Globals.MenuCommands.OPTION_MENU: {
                        return new Options();
                    }
                case Globals.MenuCommands.EXIT: {
                        Environment.Exit(1);
                    break;
                    }
            }
            return null;
        }


        public void Render() {
            Console.WriteLine(
                Globals.MenuCommands.MenuString(
                    Globals.MenuCommands.MAIN_MENU
                    ));

            Console.WriteLine(Globals.MenuCommands.CommandsListHelper([
                Globals.MenuCommands.PLAY_GAME,
                Globals.MenuCommands.OPTION_MENU,
                Globals.MenuCommands.EXIT
                ]));
        }
    }
}
