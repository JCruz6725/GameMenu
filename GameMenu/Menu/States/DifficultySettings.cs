using System.Runtime.CompilerServices;

namespace Globals.Menu.States {
    internal class DifficultyMenu : IState {
        public DifficultySettingObject difficulty = DifficultySettingObject.GetInstance();
        
        public IState? HandleInput(string input) {
            switch(input) {
                case Globals.MenuCommands.EXIT: {
                        //move back up a level
                        return new Options();
                    }
                case Globals.MenuCommands.SET: {
                    while(true) {
                        bool isint = int.TryParse(Console.ReadLine(), out int value);
                        difficulty.DifficultyLevel = value;
                        if(isint) { 
                            break;
                        }
                    }
                    return new DifficultyMenu();                
                }
            }
            return null;
        }

        public void Render() {
            Console.WriteLine($"Current setting: {difficulty.DifficultyLevel}");
            Console.WriteLine("Enter number from 1-10");
        }
    }
}
