using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO{
    [Table("FICO.tbl_BankBranch")]
    public partial class BOBankBranch
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOBankBranch()
        {
            BOBankAccount = new HashSet<BOBankAccount>();
            BOEmployeeInfo = new HashSet<BOEmployeeInfo>();
            BOEmployeeInfoRevision = new HashSet<BOEmployeeInfoRevision>();
            BOEmployeeSalary = new HashSet<BOEmployeeSalary>();
        }

        public int ID { get; set; }

        public short BankCode { get; set; }

        [StringLength(25)]
        public string ShortName { get; set; }

        [Required]
        [StringLength(255)]
        public string FullName { get; set; }

        [StringLength(510)]
        public string DisplayName { get; set; }

        [StringLength(510)]
        public string OfficialAddress { get; set; }

        [StringLength(50)]
        public string OfficialPhoneNo { get; set; }

        [StringLength(7)]
        public string PhoneExt { get; set; }

        [StringLength(50)]
        public string FaxNo { get; set; }

        [StringLength(50)]
        public string OfficialEmail { get; set; }

        [StringLength(255)]
        public string ContactPerson { get; set; }

        [StringLength(50)]
        public string ContactPersonEmail { get; set; }

        [StringLength(50)]
        public string OfficialMobileNo { get; set; }

        [StringLength(1020)]
        public string Description { get; set; }

        public int? CompanyCode { get; set; }

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

        public virtual BOBank BOBank { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOBankAccount> BOBankAccount { get; set; }

        public virtual BOUser BOUser { get; set; }

        public virtual BOUser BOUser1 { get; set; }

        public virtual BOUser BOUser2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeInfo> BOEmployeeInfo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeInfoRevision> BOEmployeeInfoRevision { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeSalary> BOEmployeeSalary { get; set; }
    }
}
