using System;
using System.Collections.Generic;
using System.Text;

namespace ANSH.SDK.API.ResponseContracts {
    /// <summary>
    /// 响应
    /// <para>数组POST</para>
    /// </summary>
    /// <typeparam name="ANSHTModelResponse">响应模型</typeparam>
    public abstract class ANSHPostArrayResponseBase<ANSHTModelResponse> : ANSHResponseBase where ANSHTModelResponse : Models.ANSHPostArrayResponseModelBase {

        /// <summary>
        /// 返回信息
        /// </summary>
        public virtual List<ANSHTModelResponse> ResultList {
            get;
            set;
        } = new List<ANSHTModelResponse> ();
    }
}