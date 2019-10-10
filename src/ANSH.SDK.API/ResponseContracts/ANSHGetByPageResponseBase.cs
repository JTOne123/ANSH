using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using ANSH.SDK.API.ResponseContracts.Models;

namespace ANSH.SDK.API.ResponseContracts {
    /// <summary>
    /// 响应
    /// <para>分页</para>
    /// </summary>
    /// <typeparam name="ANSHTModelResponse">响应模型</typeparam>
    /// <typeparam name="ANSHTPageResponesModel">分页信息模型</typeparam>
    public abstract class ANSHGetByPageResponseBase<ANSHTModelResponse, ANSHTPageResponesModel> : ANSHGetListResponseBase<ANSHTModelResponse> where ANSHTModelResponse : class
    where ANSHTPageResponesModel : IANSHPageResponesModelBase, new () {

        /// <summary>
        /// 总页数
        /// </summary>
        /// <returns></returns>
        public virtual ANSHTPageResponesModel PageInfo { get; set; } = new ANSHTPageResponesModel ();
    }
}