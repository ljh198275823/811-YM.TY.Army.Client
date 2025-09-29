using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HH.ZK.WebAPIClient
{
    public class HttpBatchOptResult
    {
        public HttpBatchOptResult()
        {
        }

        public HttpBatchOptResult(Dictionary<int, string> errors)
        {
            this.Errors = errors;
        }

        public Dictionary<int, string> Errors { get; set; }
    }
}
