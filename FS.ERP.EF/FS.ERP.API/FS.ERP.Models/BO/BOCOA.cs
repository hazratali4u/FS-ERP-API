using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO{
    [Table("FICO.tbl_COA")]
    public partial class BOCOA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOCOA()
        {
            BOSalaryBreakUpPolicyDetail = new HashSet<BOSalaryBreakUpPolicyDetail>();
            BOEquipment = new HashSet<BOEquipment>();
            BOEquipment1 = new HashSet<BOEquipment>();
            BOPartyOrCustomer = new HashSet<BOPartyOrCustomer>();
            BOBankAccount = new HashSet<BOBankAccount>();
            BOAdditionType = new HashSet<BOAdditionType>();
            BOAllowancesOrBenefit = new HashSet<BOAllowancesOrBenefit>();
            BOAllowancesOrBenefit1 = new HashSet<BOAllowancesOrBenefit>();
            BOCOA1 = new HashSet<BOCOA>();
            BOCOAMapping = new HashSet<BOCOAMapping>();
            BOCOAMappingForPCorCC = new HashSet<BOCOAMappingForPCorCC>();
            BODeductionType = new HashSet<BODeductionType>();
            BODocumentDetailOfStatement = new HashSet<BODocumentDetailOfStatement>();
            BOEmployeeInfo = new HashSet<BOEmployeeInfo>();
            BOEmployeeInfoRevision = new HashSet<BOEmployeeInfoRevision>();
            BOEmployeeSalary = new HashSet<BOEmployeeSalary>();
            BOFundDemandRegisterDetail = new HashSet<BOFundDemandRegisterDetail>();
            BOItemCategory = new HashSet<BOItemCategory>();
            BORemittanceAdviceDetail = new HashSet<BORemittanceAdviceDetail>();
            BOTransactionDetail = new HashSet<BOTransactionDetail>();
            BOVendorOrSupplier = new HashSet<BOVendorOrSupplier>();
        }

        public long ID { get; set; }

        public Guid UniqueID { get; set; }

        public byte? COAConfigurationCode { get; set; }

        public byte? COANatureCode { get; set; }

        public long? COAParentCode { get; set; }

        [Required]
        [StringLength(50)]
        public string COACode { get; set; }

        [StringLength(50)]
        public string COANo { get; set; }

        [Required]
        [StringLength(510)]
        public string COATitle { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? OpenDrAmount { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? OpenCrAmount { get; set; }

        [StringLength(1020)]
        public string Description { get; set; }

        [Column(TypeName = "date")]
        public DateTime dtOpen { get; set; }

        public bool IsJobOrProjectBase { get; set; }

        public bool IsBudgetOrForeCastBase { get; set; }

        public bool IsActive { get; set; }

        public bool CanTransaction { get; set; }

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

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOSalaryBreakUpPolicyDetail> BOSalaryBreakUpPolicyDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEquipment> BOEquipment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEquipment> BOEquipment1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOPartyOrCustomer> BOPartyOrCustomer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOBankAccount> BOBankAccount { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOAdditionType> BOAdditionType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOAllowancesOrBenefit> BOAllowancesOrBenefit { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOAllowancesOrBenefit> BOAllowancesOrBenefit1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOCOA> BOCOA1 { get; set; }

        public virtual BOCOA BOCOA2 { get; set; }

        public virtual BOCOAConfiguration BOCOAConfiguration { get; set; }

        public virtual BOCOANature BOCOANature { get; set; }

        public virtual BOUser BOUser { get; set; }

        public virtual BOUser BOUser1 { get; set; }

        public virtual BOUser BOUser2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOCOAMapping> BOCOAMapping { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOCOAMappingForPCorCC> BOCOAMappingForPCorCC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BODeductionType> BODeductionType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BODocumentDetailOfStatement> BODocumentDetailOfStatement { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeInfo> BOEmployeeInfo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeInfoRevision> BOEmployeeInfoRevision { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeSalary> BOEmployeeSalary { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOFundDemandRegisterDetail> BOFundDemandRegisterDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOItemCategory> BOItemCategory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BORemittanceAdviceDetail> BORemittanceAdviceDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOTransactionDetail> BOTransactionDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOVendorOrSupplier> BOVendorOrSupplier { get; set; }
    }
}
