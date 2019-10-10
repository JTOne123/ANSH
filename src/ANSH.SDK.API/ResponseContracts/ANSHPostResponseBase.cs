using System;
using System.Collections.Generic;
using System.Text;

namespace ANSH.SDK.API.ResponseContracts {
    /// <summary>
    /// 响应
    /// </summary>
    /// <typeparam name="ANSHTModelResponse">响应模型</typeparam>
    public abstract class ANSHPostResponseBase<ANSHTModelResponse> : ANSHResponseBase where ANSHTModelResponse : class {

        /// <summary>
        /// 返回信息
        /// </summary>
        public virtual ANSHTModelResponse ResultItem {
            get;
            set;
        }
    }
}