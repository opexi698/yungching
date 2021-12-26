using System.Configuration;

namespace yungching.Dao
{
    internal class DaoTools : WebBase.Tools
    {
        /// <summary>
        /// 取得DB連線字串
        /// </summary>
        /// <param name="connName"></param>
        /// <returns></returns>
        public static string GetDBConnectionString(string connName)
        {
            return
                ConfigurationManager.
                    ConnectionStrings[connName].ConnectionString;
        }
    }
}