using System;
namespace ANSH.SDK.API.RequestContracts.Models {
    /// <summary>
    /// Get请求参数基类
    /// </summary>
    public abstract class ANSHGetRequestModelBase {

        /// <summary>
        /// API方法名称
        /// </summary>
        public abstract string APIName {
            get;
        }

        /// <summary>
        /// API版本号
        /// </summary>
        public abstract string APIVersion {
            get;
        }

        /// <summary>
        /// 授权票据
        /// </summary>
        /// <value></value>
        public abstract string AccessToken { get; }

        /// <summary>
        /// 验证参数合法性
        /// </summary>
        /// <param name="msg">提示信息</param>
        /// <returns>验证通过返回True，验证失败返回False</returns>
        public virtual bool Validate (out string msg) {
            msg = "SUCCESS";
            return true;
        }
    }
}