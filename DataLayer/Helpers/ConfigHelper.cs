using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Helpers
{
    public static class ConfigHelper
    {
        public static string GetDataSource()
        {
            var configPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "appsettings.json");
            var json = File.ReadAllText(configPath);
            dynamic config = JsonConvert.DeserializeObject(json);
            return config.DataSource;
        }
    }
}
