using Microsoft.Extensions.Caching.Distributed;

namespace ANSH.Caches {

    /// <summary>
    /// 缓存操作
    /// </summary>
    public class ANSHCachesHandle {

        /// <summary>
        /// 缓存操作接口
        /// </summary>
        /// <value></value>
        IDistributedCache DistributedCache { get; }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="distributedCache">缓存操作接口</param>
        public ANSHCachesHandle (IDistributedCache distributedCache) {
            DistributedCache = distributedCache;
        }

        /// <summary>
        /// 设置缓存
        /// </summary>
        /// <param name="cachesBase">缓存内容</param>
        /// <typeparam name="TANSHCachesBase">缓存基类</typeparam>
        public void Set<TANSHCachesBase> (TANSHCachesBase cachesBase) where TANSHCachesBase : ANSHCachesBase => DistributedCache.SetString (cachesBase.CacheKey, cachesBase.ToJson (), cachesBase.CacheOptions);

        /// <summary>
        /// 设置缓存
        /// </summary>
        /// <param name="cachesBase">缓存内容</param>
        /// <param name="existsCachesBase">返回已存在相同CacheKey的缓存内容</param>
        /// <param name="replace">若有相同CacheKey的缓存内容是否替换</param>
        /// <typeparam name="TANSHCachesBase">缓存基类</typeparam>
        public void Set<TANSHCachesBase> (TANSHCachesBase cachesBase, out TANSHCachesBase existsCachesBase, bool replace = true) where TANSHCachesBase : ANSHCachesBase {

            existsCachesBase = Get<TANSHCachesBase> (cachesBase);

            if (replace) {
                Set (cachesBase);
            }
        }

        /// <summary>
        /// 获取缓存
        /// </summary>
        /// <param name="cacheKey">缓存键</param>
        /// <typeparam name="TANSHCachesBase">缓存基类</typeparam>
        public TANSHCachesBase Get<TANSHCachesBase> (TANSHCachesBase cacheKey) where TANSHCachesBase : ANSHCachesBase {
            string cacheValue = DistributedCache.GetString (cacheKey.CacheKey);
            if (!string.IsNullOrWhiteSpace (cacheValue)) {
                return cacheValue.ToJsonObj<TANSHCachesBase> ();
            }
            return null;
        }
    }
}