using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO{
    [Table("AppCNF.tbl_LocationSite")]
    public partial class BOLocationSite
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOLocationSite()
        {
            BOEmployeeIncrement = new HashSet<BOEmployeeIncrement>();
            BOEmployeeInfo = new HashSet<BOEmployeeInfo>();
            BOEmployeeInfo1 = new HashSet<BOEmployeeInfo>();
            BOEmployeeInfoRevision = new HashSet<BOEmployeeInfoRevision>();
            BOEmployeeInfoRevision1 = new HashSet<BOEmployeeInfoRevision>();
            BOEmployeeSalary = new HashSet<BOEmployeeSalary>();
            BOEquipment = new HashSet<BOEquipment>();
            BOLocationSite1 = new HashSet<BOLocationSite>();
            BOUser3 = new HashSet<BOUser>();
            BOUserLocationSitePermission = new HashSet<BOUserLocationSitePermission>();
            BOGatePass = new HashSet<BOGatePass>();
            BOGRNandReturn = new HashSet<BOGRNandReturn>();
            BOProductionMaster = new HashSet<BOProductionMaster>();
            BOPurchaseOrderAndReturn = new HashSet<BOPurchaseOrderAndReturn>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public Guid? UniqueID { get; set; }

        public int? LocationSiteCode { get; set; }

        public byte LocationSiteTypeCode { get; set; }

        public long? PartyOrCustomerCode { get; set; }

        [StringLength(11)]
        public string LevelType { get; set; }

        [StringLength(7)]
        public string CategoryType { get; set; }

        [StringLength(11)]
        public string RegionType { get; set; }

        [StringLength(25)]
        public string ShortName { get; set; }

        [Required]
        [StringLength(255)]
        public string FullName { get; set; }

        [Required]
        [StringLength(510)]
        public string DisplayName { get; set; }

        [StringLength(1020)]
        public string Description { get; set; }

        public bool? IsOperative { get; set; }

        public bool? IsCrossBorder { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MinHumidity { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MaxHumidity { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MinTemperature { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MaxTemperature { get; set; }

        public short? MUnitTemperatureCode { get; set; }

        public short? MUnitLWHCode { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Length { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Width { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Height { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DiaMeter { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? OpenAreaLength { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? OpenAreaWidth { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? OpenAreaHeight { get; set; }

        public int? NoOfPallets { get; set; }

        public int? NoOfPartions { get; set; }

        public int? NoOfTables { get; set; }

        public int? NoOfPersons { get; set; }

        public int? ManagerCode { get; set; }

        public int? AsstManagerCode { get; set; }

        public int CompanyCode { get; set; }

        public DateTime? dtmExported { get; set; }

        public DateTime? dtmImported { get; set; }

        public DateTime dtmCreated { get; set; }

        public DateTime dtmLastM { get; set; }

        public int OwnerCode { get; set; }

        public int CreatedByCode { get; set; }

        public int AlteredByCode { get; set; }

        public byte RecordStatusCode { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeIncrement> BOEmployeeIncrement { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeInfo> BOEmployeeInfo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeInfo> BOEmployeeInfo1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeInfoRevision> BOEmployeeInfoRevision { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeInfoRevision> BOEmployeeInfoRevision1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeSalary> BOEmployeeSalary { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEquipment> BOEquipment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOLocationSite> BOLocationSite1 { get; set; }

        public virtual BOLocationSite BOLocationSite2 { get; set; }

        public virtual BOLocationSiteType BOLocationSiteType { get; set; }

        public virtual BOOrganizationCompany BOOrganizationCompany { get; set; }

        public virtual BOPartyOrCustomer BOPartyOrCustomer { get; set; }

        public virtual BORecordStatus BORecordStatus { get; set; }

        public virtual BOUser BOUser { get; set; }

        public virtual BOUser BOUser1 { get; set; }

        public virtual BOUser BOUser2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOUser> BOUser3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOUserLocationSitePermission> BOUserLocationSitePermission { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOGatePass> BOGatePass { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOGRNandReturn> BOGRNandReturn { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOProductionMaster> BOProductionMaster { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOPurchaseOrderAndReturn> BOPurchaseOrderAndReturn { get; set; }
    }
}
