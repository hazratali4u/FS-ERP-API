using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO {
    [Table("HRM.tbl_BudgetPlan")]
    public partial class BOBudgetPlan
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }
        [Required]
        public int DeptCode { get; set; }
        [Required]
        public short FiscalYearCode { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public decimal Amount { get; set; }
        public int CompanyCode { get; set; }

        public DateTime dtmCreated { get; set; }

        public DateTime dtmLastM { get; set; }

        public int OwnerCode { get; set; }

        public int CreatedByCode { get; set; }

        public int AlteredByCode { get; set; }

        public byte RecordStatusCode { get; set; }

    }
}
