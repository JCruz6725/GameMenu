namespace Globals.Menu.States {
    internal class DifficultySettingObject {

        #region Singleton
        private DifficultySettingObject() { }

        private static DifficultySettingObject? Instance;

        public static DifficultySettingObject GetInstance() {
            if(Instance is null) {
                Instance = new DifficultySettingObject();
            }
            return Instance;
        }
        #endregion
    
        public int DifficultyLevel { get; set; } = 1;
    }
}
