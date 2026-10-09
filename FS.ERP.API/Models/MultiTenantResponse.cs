using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.BO.MultiTanent
{
    public class MultiTenantResponse
    {
        public long ClientId { get; set; }

        public bool IsSuccess { get; set; }

        public string Message { get; set; }

        public string DbInfo { get; set; }

        public DateTime? ExpiryDate { get; set; }

        public DateTime? EndDate { get; set; }

        public string ExpiryMessage { get; set; }
    }
}
