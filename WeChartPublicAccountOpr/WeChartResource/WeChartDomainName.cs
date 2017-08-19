using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeChartPublicAccountOpr.WeChartResource
{
    /// <summary>
    /// 表示微信公众号的服务器域名资源。
    /// </summary>
    public class WeChartDomainName
    {
        /// <summary>
        /// 通用域名(api.weixin.qq.com)，使用该域名将访问官方指定就近的接入点。
        /// </summary>
        public const string CommonDomainName = "api.weixin.qq.com";
        
        /// <summary>
        /// 上海域名(sh.api.weixin.qq.com)，使用该域名将访问上海的接入点。
        /// </summary>
        public const string ShangHaiDomainName = "sh.api.weixin.qq.com";

        /// <summary>
        /// 深圳域名(sz.api.weixin.qq.com)，使用该域名将访问深圳的接入点。
        /// </summary>
        public const string ShengZhengDomainName = "sz.api.weixin.qq.com";

        /// <summary>
        /// 香港域名(hk.api.weixin.qq.com)，使用该域名将访问香港的接入点。
        /// </summary>
        public const string HongKongDomainName = "hk.api.weixin.qq.com";

        /// <summary>
        /// 获取/设置当前使用的域名，默认值为CommonDomainName。
        /// </summary>
        public static string CurrentDomainName { get; set; } = CommonDomainName;

    }
}
