﻿namespace Test.Angular.SignalR.Model
{
    /// <summary>
    /// Cloud API response
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ApiResponse<T>
    {
        public ApiResponse() : this(default(T))
        {
        }

        public ApiResponse(T data)
        {
            Response = data;
        }

        /// <summary>
        /// Response body
        /// </summary>
        public T Response { get; set; }
    }
}
