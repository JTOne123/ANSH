﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ANSH.API.ResponseContracts;
using Newtonsoft.Json;
namespace ANSH.API.RequestContracts {
    /// <summary>
    /// 请求
    /// <para>POST</para>
    /// </summary>
    /// <typeparam name="TResponse">响应</typeparam>
    public abstract class POSTRequest<TResponse> : BaseRequest where TResponse : BaseResponse {

    }
}