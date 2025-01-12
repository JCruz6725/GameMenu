using System.Text;

namespace Globals {
    class MenuCommands {
        public const string MAIN_MENU = "MainMenu";
        public const string OPTION_MENU= "Options";
        public const string PLAY_GAME = "Start";
        public const string EXIT = "Exit";
        public const string DIFFICULTY = "Difficulty";
        public const string SET = "Set";

        public static string CommandsListHelper(string[] commands) {
            StringBuilder sb = new ();
            sb.Append("Avalible commands ");

            string cmdList = "[";
            foreach(string cmd in commands) {
                cmdList += string.Concat([
                    string.Concat(["'",cmd,"'"])
                    , ", "]);
            }
            cmdList = string.Concat([cmdList.Substring (0, cmdList.Length - 2), "]"]);

            sb.Append(cmdList);
            return sb.ToString();
        }
    }
}
