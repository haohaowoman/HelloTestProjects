using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WeChartPublicAccountOpr.WeChartResource
{
    /// <summary>
    /// 微信公众号的接口响应错误码。
    /// </summary>
    public class ResponseErrorCode
    {
        /// <summary>
        /// 接口响应成功的错误码。
        /// </summary>
        public const int SucceedCode = 0;

        /// <summary>
        /// 获取/设置错误码。
        /// </summary>
        public int ErrorCode { get; set; }

        /// <summary>
        /// 获取/设置错误信息。
        /// </summary>
        public string Message { get; set; }

        // 用于储存接口响应错误码与错误说明的数据词典。
        private static Dictionary<int, string> _errorCodes;

        static ResponseErrorCode()
        {
            _errorCodes = new Dictionary<int, string>();
            
        }
    }
}
