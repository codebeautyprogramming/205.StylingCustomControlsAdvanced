using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook
{
    public static class ConfigurationManager
    {
        public static JObject LoadThemeConfig(int ?theme=1)
        {
            string themePath;
            if (theme == 2)
                themePath = "themeConfig2.json";
            else
                themePath = "themeConfig.json";

            if (File.Exists(themePath))
            {
                string config = File.ReadAllText(themePath);
                return JObject.Parse(config);
            }
            return null;
        }
    }
}
