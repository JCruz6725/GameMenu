using GameMenu.Menu.States;

namespace Globals.Menu.States {
    internal class Options : IState {

        public IState? HandleInput(string input) {
            switch(input) {
                case Globals.MenuCommands.DIFFICULTY: {
                        return new DifficultyMenu();
                    }

                case Globals.MenuCommands.AUDIO: {
                        return new AudioMenu();
                    }

                case Globals.MenuCommands.EXIT: {
                        //move back up.
                        return new MainMenu();
                    }
            }
            return null;
        }

        public void Render() {
            Console.WriteLine(
                Globals.MenuCommands.MenuString(
                    Globals.MenuCommands.OPTION_MENU
                    ));

            Console.WriteLine(Globals.MenuCommands.CommandsListHelper([
                Globals.MenuCommands.DIFFICULTY,
                Globals.MenuCommands.AUDIO,
                Globals.MenuCommands.EXIT
                ]));

        }
    }
}
