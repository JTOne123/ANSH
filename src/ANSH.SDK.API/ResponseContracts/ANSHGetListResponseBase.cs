using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace ANSH.SDK.API.ResponseContracts {
    /// <summary>
    /// 响应
    /// </summary>
    /// <typeparam name="ANSHTModelResponse">响应模型</typeparam>
    public abstract class ANSHGetListResponseBase<ANSHTModelResponse> : ANSHResponseBase where ANSHTModelResponse : class {

        /// <summary>
        /// 返回信息
        /// </summary>
        public virtual List<ANSHTModelResponse> ResultList { get; set; } = new List<ANSHTModelResponse> ();
    }
}