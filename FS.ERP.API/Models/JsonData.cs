using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FS.ERP.API.Models
{
    public class JsonData
    {
        public bool IsError { get; set; }

        public bool IsAlert { get; set; }

        public bool IsSuccess { get; set; }

        public bool IsWarning { get; set; }

        public string Message { get; set; }

        public object Data { get; set; }
    }
}