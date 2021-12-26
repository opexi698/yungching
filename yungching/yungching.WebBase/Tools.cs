using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yungching.WebBase
{
    public class Tools
    {
        /// <summary>
        /// 取得Config
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string GetAppsetting(string key)
        {
            string AppSetting = string.IsNullOrEmpty(ConfigurationManager.AppSettings[key]) ? ConfigurationManager.AppSettings[key] : string.Empty ;
            return AppSetting;
        }
    }
}
