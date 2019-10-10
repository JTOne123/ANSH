using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ANSH.SDK.API.ResponseContracts;
using ANSH.SDK.API.ResponseContracts.Models;

namespace ANSH.SDK.API.RequestContracts {
    /// <summary>
    /// 请求
    /// <para>分页</para>
    /// </summary>
    /// <typeparam name="ANSHTResponse">响应</typeparam>
    /// <typeparam name="ANSHTModelResponse">响应模型</typeparam>
    /// <typeparam name="ANSHTPageResponesModel">分页信息模型</typeparam>
    public abstract class ANSHGetByPageRequestBase<ANSHTResponse, ANSHTModelResponse, ANSHTPageResponesModel> : ANSHGetListRequestBase<ANSHTResponse, ANSHTModelResponse>
        where ANSHTResponse : ANSHGetByPageResponseBase<ANSHTModelResponse, ANSHTPageResponesModel>
        where ANSHTModelResponse : class
    where ANSHTPageResponesModel : IANSHPageResponesModelBase, new () {
        /// <summary>
        /// 列表分页当前页
        /// </summary>
        public virtual string PageCur {
            get;
            set;
        } = "1";

        /// <summary>
        /// 列表分页每页显示条数
        /// </summary>
        public virtual string PageSize {
            get;
            set;
        } = "50";

        /// <summary>
        /// 每页显示条数上限
        /// </summary>
        protected virtual int PageSizeLimit {
            get;
            set;
        } = 200;

        /// <summary>
        /// 获取URL参数
        /// </summary>
        public override Dictionary<string, string> GetParameters () {
            var page_paramters = SetByPageParameters ();
            var set_paramters = SetParameters () ?? new Dictionary<string, string> ();
            foreach (var in_set_paramters in set_paramters) {
                page_paramters.Add (in_set_paramters.Key, in_set_paramters.Value);
            }
            return page_paramters;
        }

        /// <summary>
        /// 准备URL参数
        /// </summary>
        Dictionary<string, string> SetByPageParameters () => new Dictionary<string, string> {
            ["pageCur"] = PageCur,
            ["pageSize"] = PageSize
        };

        /// <summary>
        /// 验证参数合法性
        /// </summary>
        /// <param name="msg">提示信息</param>
        /// <returns>验证通过返回True，验证失败返回False</returns>
        public override bool Validate (out string msg) {
            if (!base.Validate (out msg)) { return false; }

            if (!PageCur.IsInt (out int _page_cur) || _page_cur < 1) {
                msg = $"参数pageCur格式错误，应为大于等于1的整数";
                return false;
            }

            if (!PageSize.IsInt (out int _page_size) || _page_size < 1) {
                msg = $"参数pageSize格式错误，应为大于等于1的整数";
                return false;
            }

            if (_page_size > PageSizeLimit) {
                msg = $"参数pageSize错误，每页显示条数上限为{PageSizeLimit}";
                return false;
            }
            return true;
        }
    }
}