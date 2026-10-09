using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FS.ERP.Models
{
    [Table("tbl_MultiTenant")]
    public partial class BOMultiTenant
    {
        public long Id { get; set; }

        [StringLength(255)]
        public string ClientName { get; set; }

        [StringLength(255)]
        public string ClientUser { get; set; }

        [StringLength(1020)]
        public string PinCode { get; set; }

        [StringLength(2040)]
        public string DBConInfo { get; set; }

        [StringLength(255)]
        public string ServerName { get; set; }

        [StringLength(255)]
        public string ServerInstance { get; set; }

        [StringLength(11)]
        public string ServerPort { get; set; }

        [StringLength(255)]
        public string DBUserName { get; set; }

        [StringLength(255)]
        public string DBUserPWD { get; set; }

        [StringLength(255)]
        public string DBAuthentication { get; set; }

        [Column(TypeName = "date")]
        public DateTime? RegDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? StartDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? EndDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ExpiryDate { get; set; }

        public bool? IsDemo { get; set; }

        public bool? IsOperative { get; set; }
    }
}
