namespace Globals.Menu.States {
    internal class DifficultyMenu : IState {
        public DifficultySettingObject difficulty = DifficultySettingObject.GetInstance();
        
        public IState? HandleInput(string input) {
            switch(input) {
                case Globals.MenuCommands.SET: {
                    while(true) {
                        Console.WriteLine("\n\nEnter number from 1-10");
                        bool isint = int.TryParse(Console.ReadLine(), out int value);
                        difficulty.DifficultyLevel = value;
                        if(isint) { 
                            break;
                        }
                    }
                    return new DifficultyMenu();                
                }
                case Globals.MenuCommands.EXIT: {
                        //move back up a level
                        return new Options();
                    }
            }
            return null;
        }

        public void Render() {
            Console.WriteLine($"Current setting: {difficulty.DifficultyLevel}");
            Console.WriteLine($"Avalible commands ['{Globals.MenuCommands.SET}, {Globals.MenuCommands.EXIT}']");
        }
    }
}
