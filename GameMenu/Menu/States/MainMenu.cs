﻿namespace Globals.Menu.States {
    internal class MainMenu : IState {

        public IState? HandleInput(string input) {
            switch(input) {
                case Globals.MenuCommands.OPTION_MENU: {
                        return new Options();
                    }
                case Globals.MenuCommands.PLAY_GAME: {
                        return new Game();
                    }
            }
            return null;
        }


        public void Render() {
            Console.WriteLine("*****************");
            Console.WriteLine("****Main Menu****");
            Console.WriteLine("*****************");
            Console.WriteLine($"Avalible commands ['{Globals.MenuCommands.PLAY_GAME}, {Globals.MenuCommands.OPTION_MENU}']");
        }

    }
}
