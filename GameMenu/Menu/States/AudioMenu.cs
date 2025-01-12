using Globals.Menu;
using Globals.Menu.States;

namespace GameMenu.Menu.States {
    internal class AudioMenu : IState {

        private readonly AudioSettingsObject audioSettingsObject = AudioSettingsObject.GetInstance();

        public IState? HandleInput(string input) {
            switch (input) {
                case Globals.MenuCommands.SET: {
                    while(true) {
                            Console.WriteLine("\n\nEnter number from 1-10");
                            bool isint = int.TryParse(Console.ReadLine(), out int level);
                            if(isint) {
                                audioSettingsObject.AudioLevel = level;
                                break;
                            }
                    }
                    return new AudioMenu(); 
                }
                
                case Globals.MenuCommands.EXIT: {
                    return new Options();
                }
            }
            return null;
        }

        public void Render() {
            Console.WriteLine(Globals.MenuCommands.MenuString("AudioSettings"));
            Console.WriteLine($"CurrentLevel: {audioSettingsObject.AudioLevel}");
            
            Console.WriteLine(Globals.MenuCommands.CommandsListHelper([
                Globals.MenuCommands.SET,
                Globals.MenuCommands.EXIT
            ]));
        }
    }
}
