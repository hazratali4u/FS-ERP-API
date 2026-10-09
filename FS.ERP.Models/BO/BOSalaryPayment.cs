using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO{
    [Table("HRM.tbl_SalaryPayment")]
    public partial class BOSalaryPayment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }
        public long? EmpCode { get; set; }
        public long? EmpSalaryCode { get; set; }

        public int? CostOrProfitCenterCode { get; set; }
        public string ChequeNumber { get; set; }
        public long? COACode { get; set; }
        public string Description { get; set; }

        public int CompanyCode { get; set; }

        public DateTime dtmCreated { get; set; }

        public DateTime dtmLastM { get; set; }

        public int OwnerCode { get; set; }

        public int CreatedByCode { get; set; }

        public int AlteredByCode { get; set; }

        public byte RecordStatusCode { get; set; }

    }
}
