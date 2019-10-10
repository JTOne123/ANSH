using System.Collections.Generic;

namespace ANSH.Caches {

    /// <summary>
    /// 多条缓存基类
    /// </summary>
    /// <typeparam name="TModel">缓存模型</typeparam>
    public abstract class ANSHCachesListBase<TModel> : ANSHCachesBase {
        /// <summary>
        /// 构造函数
        /// </summary>
        public ANSHCachesListBase () {
        }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="cacheKey">缓存键</param>
        /// <param name="cacheValue">缓存值</param>
        public ANSHCachesListBase (string cacheKey, List<TModel> cacheValue) : base (cacheKey) {
            CachesValue = cacheValue;
        }

        /// <summary>
        /// 缓存值
        /// </summary>
        /// <value></value>
        public List<TModel> CachesValue { get; set; }
    }
}