using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO{
    [Table("UMS.tbl_SystemOrWebPool")]
    public partial class BOSystemOrWebPool
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOSystemOrWebPool()
        {
            BOUserSystemOrWebPermission = new HashSet<BOUserSystemOrWebPermission>();
        }

        public long ID { get; set; }

        [StringLength(50)]
        public string MacAddress { get; set; }

        [StringLength(50)]
        public string strAlternateMacAddress { get; set; }

        [StringLength(50)]
        public string WMacAddress { get; set; }

        [Required]
        [StringLength(25)]
        public string LocalIP { get; set; }

        [StringLength(25)]
        public string LiveIP { get; set; }

        [StringLength(125)]
        public string DomainServer { get; set; }

        [StringLength(25)]
        public string DomainIP { get; set; }

        [StringLength(125)]
        public string SMTPServer { get; set; }

        [StringLength(25)]
        public string SMTPIP { get; set; }

        [StringLength(125)]
        public string DNSServer { get; set; }

        [StringLength(125)]
        public string RouterMapping { get; set; }

        [StringLength(25)]
        public string DefaultGateway { get; set; }

        [StringLength(125)]
        public string AlternateDNSServer { get; set; }

        [StringLength(25)]
        public string SysType { get; set; }

        [StringLength(255)]
        public string SysName { get; set; }

        [StringLength(255)]
        public string SysModel { get; set; }

        [StringLength(255)]
        public string SysProcessor { get; set; }

        [StringLength(255)]
        public string SysRAM { get; set; }

        [StringLength(255)]
        public string SysHDD { get; set; }

        [StringLength(255)]
        public string SysAlternateHDD { get; set; }

        [StringLength(1020)]
        public string SysDevices { get; set; }

        [StringLength(1020)]
        public string WebAddress { get; set; }

        public bool? IsBrowsingAllowed { get; set; }

        public bool? IsScanningAllowed { get; set; }

        public bool? IsPrintingAllowed { get; set; }

        public bool? IsCamAvailable { get; set; }

        public bool? IsRFIDAvailable { get; set; }

        public bool? IsFingerPrintAvailable { get; set; }

        public bool IsBlocked { get; set; }

        public int CompanyCode { get; set; }

        public DateTime? dtmUpLoaded { get; set; }

        public DateTime? dtmDownLoaded { get; set; }

        public DateTime? dtmExported { get; set; }

        public DateTime? dtmImported { get; set; }

        public DateTime dtmCreated { get; set; }

        public DateTime dtmLastM { get; set; }

        public int OwnerCode { get; set; }

        public int CreatedByCode { get; set; }

        public int AlteredByCode { get; set; }

        public byte RecordStatusCode { get; set; }

        public virtual BOOrganizationCompany BOOrganizationCompany { get; set; }

        public virtual BORecordStatus BORecordStatus { get; set; }

        public virtual BOUser BOUser { get; set; }

        public virtual BOUser BOUser1 { get; set; }

        public virtual BOUser BOUser2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOUserSystemOrWebPermission> BOUserSystemOrWebPermission { get; set; }
    }
}
