using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImportDeviceToken.WebAPI.Models.Error
{
    public class Error
    {
        public ErrorData error { get; set; }
    }

    /// <summary>
    /// Model for error response
    /// </summary>
    //[ModelName("Error Model")]
    public class ErrorData
    {
        /// <summary>
        /// Code
        /// </summary>
        public int code { get; set; }
        /// <summary>
        /// Context
        /// </summary>
        public string context { get; set; }
        /// <summary>
        /// Error Message
        /// </summary>
        public string message { get; set; }
        /// <summary>
        /// Status code
        /// </summary>
        public int status_code { get; set; }
    }

    public class ErrResponse
    {
        public string Message { get; set; }
    }
}
