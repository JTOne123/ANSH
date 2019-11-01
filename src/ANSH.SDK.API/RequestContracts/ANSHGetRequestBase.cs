using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ANSH.SDK.API.RequestContracts.Models;
using ANSH.SDK.API.ResponseContracts;

namespace ANSH.SDK.API.RequestContracts {

    /// <summary>
    /// 请求
    /// <para>GET</para>
    /// </summary>
    /// <typeparam name="ANSHQueryRequest">查询参数</typeparam>
    /// <typeparam name="ANSHTResponse">响应</typeparam>
    /// <typeparam name="ANSHTModelResponse">响应模型</typeparam>
    public abstract class ANSHGetRequestBase<ANSHQueryRequest, ANSHTResponse, ANSHTModelResponse> : ANSHRequestBase<ANSHTResponse>
        where ANSHTResponse : ANSHGetResponseBase<ANSHTModelResponse>
        where ANSHTModelResponse : class
    where ANSHQueryRequest : ANSHGetRequestModelBase {

        /// <summary>
        /// 查询参数
        /// </summary>
        /// <value></value>
        public ANSHQueryRequest Query { get; set; }
    }
}