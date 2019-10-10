using Microsoft.Extensions.Caching.Distributed;

namespace ANSH.Caches {

    /// <summary>
    /// 缓存基类
    /// </summary>
    public abstract class ANSHCachesBase {

        /// <summary>
        /// 构造函数
        /// </summary>
        public ANSHCachesBase () { }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="cacheKey">缓存键</param>
        public ANSHCachesBase (string cacheKey) {
            CacheKey = cacheKey.MD5Encryp ().ToX2String ();
        }

        /// <summary>
        /// 缓存键
        /// </summary>
        /// <value></value>
        public virtual string CacheKey { get; set; }

        /// <summary>
        /// 缓存配置
        /// </summary>
        /// <value></value>
        public virtual DistributedCacheEntryOptions CacheOptions { get; set; }
    }
}