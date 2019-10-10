using System;
using Newtonsoft.Json;

namespace ANSH.MQ.RabbitMQ {
    /// <summary>
    /// 消息模型基类
    /// </summary>
    [JsonObject (MemberSerialization.OptOut)]
    public abstract class ANSHMQMessageBase {
        /// <summary>
        /// 队列名称
        /// </summary>
        public abstract string Queue { get; }

        /// <summary>
        /// 消息rootkey
        /// </summary>
        public abstract string RootKey { get; }
    }
}