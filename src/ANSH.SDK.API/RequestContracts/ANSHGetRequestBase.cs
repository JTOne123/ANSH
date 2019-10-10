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
    /// <typeparam name="ANSHTResponse">响应</typeparam>
    /// <typeparam name="ANSHTModelResponse">响应模型</typeparam>
    public abstract class ANSHGetRequestBase<ANSHTResponse, ANSHTModelResponse> : ANSHRequestBase<ANSHTResponse>
        where ANSHTResponse : ANSHGetResponseBase<ANSHTModelResponse>
        where ANSHTModelResponse : class {

            /// <summary>
            /// 获取URL参数
            /// </summary>
            /// <returns>url参数集合</returns>
            public virtual Dictionary<string, string> GetParameters () {
                return SetParameters ();
            }

            /// <summary>
            /// 设置URL参数
            /// </summary>
            /// <returns>url参数集合</returns>
            public abstract Dictionary<string, string> SetParameters ();
        }
}