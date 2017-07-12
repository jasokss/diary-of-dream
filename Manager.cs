using System.IO;
using System.Windows.Forms;
using Diary.Database;

namespace Diary
{
    public static class Manager
    {
        private static ConfigurationData _configuration;
        private static Adapter _connection;

        public static ConfigurationData GetConfig()
        {
            _configuration = new ConfigurationData(Path.Combine(Application.StartupPath, @"config.ini"));
            return _configuration;
        }

        public static Adapter GetDatabaseManager()
        {
            _connection = new Adapter(GetConfig().data["db.hostname"], GetConfig().data["db.name"], GetConfig().data["db.username"], GetConfig().data["db.password"]);
            return _connection;
        }
    }
}
