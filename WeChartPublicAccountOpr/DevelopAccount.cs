using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeChartPublicAccountOpr
{
    /// <summary>
    /// 表示开发者帐号。
    /// 通过微信公众号官方网站登录公众号获取公众号开发者帐户的appID与appSecret。
    /// </summary>
    public class DevelopAccount
    {
        /// <summary>
        /// 创建开发都帐户，设置appID与appSecret为“”。
        /// </summary>
        public DevelopAccount()
        {
            AppID = AppSecret = string.Empty;
        }

        /// <summary>
        /// 通过指定微信公众号开发者帐户的appID与appSecret创建开发者帐户。
        /// </summary>
        /// <param name="appID">帐号信息的appID。</param>
        /// <param name="appSecret">帐号信息的appsecret。</param>
        public DevelopAccount(string appID, string appSecret)
        {
            AppID = appID;
            AppSecret = appSecret;
        }

        #region Properties

        /// <summary>
        /// 获取/设置公众号开发者帐户信息的appID。
        /// </summary>
        public string AppID { get; set; }

        /// <summary>
        /// 获取/设置公众号开发者帐户信息的appSecret。
        /// </summary>
        public string AppSecret { get; set; }

        #endregion
    }
}
