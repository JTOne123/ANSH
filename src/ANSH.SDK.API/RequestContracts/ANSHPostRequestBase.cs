using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ANSH.SDK.API.RequestContracts.Models;
using ANSH.SDK.API.ResponseContracts;
using ANSH.SDK.API.ResponseContracts.Models;
using Newtonsoft.Json;
namespace ANSH.SDK.API.RequestContracts {
    /// <summary>
    /// 请求
    /// </summary>
    /// <typeparam name="ANSHTResponse">响应</typeparam>
    /// <typeparam name="ANSHTMODELRequest">请求模型</typeparam>
    /// <typeparam name="ANSHTModelResponse">响应模型</typeparam>
    public abstract class ANSHPostRequestBase<ANSHTResponse, ANSHTMODELRequest, ANSHTModelResponse> : ANSHRequestBase<ANSHTResponse>
        where ANSHTResponse : ANSHPostResponseBase<ANSHTModelResponse>
        where ANSHTMODELRequest : ANSHPostRequestModelBase
    where ANSHTModelResponse : class {

        /// <summary>
        /// 提交内容
        /// </summary>
        public virtual ANSHTMODELRequest PostItem {
            get;
            set;
        }

        /// <summary>
        /// 验证参数合法性
        /// </summary>
        /// <param name="msg">提示信息</param>
        /// <returns>验证通过返回True，验证失败返回False</returns>
        public override bool Validate (out string msg) {
            if (!base.Validate (out msg)) {
                return false;
            }
            if (PostItem is null) {
                msg = $"参数$postItem不能为空。";
                return false;
            }
            return true;
        }
    }
}