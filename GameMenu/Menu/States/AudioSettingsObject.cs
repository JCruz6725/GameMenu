namespace GameMenu.Menu.States {
    internal class AudioSettingsObject {

        #region Singleton
        private AudioSettingsObject() { }

        private static AudioSettingsObject? Instance;

        public static AudioSettingsObject GetInstance() {
            if(Instance is null) {
                Instance = new AudioSettingsObject();
            }
            return Instance;
        }
        #endregion

        public int AudioLevel = 1;
    }
}
