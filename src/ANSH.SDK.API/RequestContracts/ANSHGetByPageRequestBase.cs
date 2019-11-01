using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ANSH.SDK.API.RequestContracts.Models;
using ANSH.SDK.API.ResponseContracts;
using ANSH.SDK.API.ResponseContracts.Models;

namespace ANSH.SDK.API.RequestContracts {
    /// <summary>
    /// 请求
    /// <para>分页</para>
    /// </summary>
    /// <typeparam name="ANSHQueryRequest">查询参数</typeparam>
    /// <typeparam name="ANSHTResponse">响应</typeparam>
    /// <typeparam name="ANSHTModelResponse">响应模型</typeparam>
    /// <typeparam name="ANSHTPageResponesModel">分页信息模型</typeparam>
    public abstract class ANSHGetByPageRequestBase<ANSHQueryRequest, ANSHTResponse, ANSHTModelResponse, ANSHTPageResponesModel> : ANSHGetListRequestBase<ANSHQueryRequest, ANSHTResponse, ANSHTModelResponse>
        where ANSHTResponse : ANSHGetByPageResponseBase<ANSHTModelResponse, ANSHTPageResponesModel>
        where ANSHTModelResponse : class
    where ANSHTPageResponesModel : IANSHPageResponesModelBase, new ()
    where ANSHQueryRequest : ANSHGetByPageRequestModelBase {

    }
}