namespace Task_1
{
    public class ConfigurationManager
    {
        private static ConfigurationManager _instance;
        private string _logMode;
        private string _databaseConnection;

        private readonly DisplayHelper _displayHelper;

        private ConfigurationManager()
        {
            _displayHelper = new DisplayHelper();
        }

        public static ConfigurationManager Instance => _instance ??= new ConfigurationManager();

        public string LogMode
        {
            get => _logMode;
            set => SetAndDisplaySetting("Log Mode", ref _logMode, value);
        }

        public string DatabaseConnection
        {
            get => _databaseConnection;
            set => SetAndDisplaySetting("Database Connection", ref _databaseConnection, value);
        }

        public void DisplaySettings()
        {
            _displayHelper.DisplayHeading("Current Configuration Settings:");
            DisplaySetting("Log Mode", _logMode);
            DisplaySetting("Database Connection", _databaseConnection);
            _displayHelper.DisplayEmptyLine();
        }

        public void SetConfiguration(string logMode, string databaseConnection)
        {
            SetAndDisplaySetting("Log Mode", ref _logMode, logMode);
            SetAndDisplaySetting("Database Connection", ref _databaseConnection, databaseConnection);
        }

        private void SetAndDisplaySetting(string settingName, ref string settingField, string settingValue)
        {
            settingField = settingValue;
            DisplaySetting(settingName, settingValue);
        }

        private void DisplaySetting(string settingName, string settingValue)
        {
            _displayHelper.DisplayMessage($"{settingName}: {settingValue}");
        }
    }
}