using DataLayer.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataLayer.Helpers
{
    public static class ConfigManager
    {
        private static readonly string ConfigPath = "config.txt";

        public static AppSettings LoadConfig()
        {
            if (!File.Exists(ConfigPath))
                return null;

            var json = File.ReadAllText(ConfigPath);
            return JsonConvert.DeserializeObject<AppSettings>(json);
        }

        public static void SaveConfig(AppSettings settings)
        {
            var json = JsonConvert.SerializeObject(settings, Formatting.Indented);
            File.WriteAllText(ConfigPath, json);
        }
    }
}
