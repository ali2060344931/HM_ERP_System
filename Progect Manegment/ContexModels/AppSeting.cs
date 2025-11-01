using System.Configuration;

namespace Manegmen_Machinery.ContexModels
{
    public class AppSeting
    {
        //تهیه شده توسط غلام زاده 1401/10/25
        private Configuration Config;
        public AppSeting()
        {
            Config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        }
        public string GetConnectionString(string key)
        {
            return Config.ConnectionStrings.ConnectionStrings[key].ConnectionString;
        }
        public void SaveConnectionString(string key, string value)
        {
            
            //todo سایت فیلم آموزش https://www.youtube.com/watch?v=-KdqdWTNO7Q
            Config.ConnectionStrings.ConnectionStrings[key].ConnectionString = value;
            Config.ConnectionStrings.ConnectionStrings[key].ProviderName = "System.Data.SqlClient";
            Config.Save(ConfigurationSaveMode.Modified);
        }
    }
}
