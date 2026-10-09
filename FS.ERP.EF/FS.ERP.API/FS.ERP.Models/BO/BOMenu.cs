using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO{
    [Table("MenuCNF.tbl_Menu")]
    public partial class BOMenu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOMenu()
        {
            BOTransactionDocumentProcess = new HashSet<BOTransactionDocumentProcess>();
            BOActionLogging = new HashSet<BOActionLogging>();
            BOAPPCNFDataLogging = new HashSet<BOAPPCNFDataLogging>();
            BOCRMDataLogging = new HashSet<BOCRMDataLogging>();
            BOErrorLogging = new HashSet<BOErrorLogging>();
            BOFICODataLogging = new HashSet<BOFICODataLogging>();
            BOHRMDataLogging = new HashSet<BOHRMDataLogging>();
            BOIMMDataLogging = new HashSet<BOIMMDataLogging>();
            BOSRMDataLogging = new HashSet<BOSRMDataLogging>();
            BOUMSDataLogging = new HashSet<BOUMSDataLogging>();
            BOMenuControlInfo = new HashSet<BOMenuControlInfo>();
            BOModuleColInfo = new HashSet<BOModuleColInfo>();
            BOModuleParamInfo = new HashSet<BOModuleParamInfo>();
            BOProfileGroupDetail = new HashSet<BOProfileGroupDetail>();
            BOReportDashboardInfo = new HashSet<BOReportDashboardInfo>();
            BOUser3 = new HashSet<BOUser>();
            BOUserMenuAdditionSubtraction = new HashSet<BOUserMenuAdditionSubtraction>();
            BOUserMenuAdditionSubtraction1 = new HashSet<BOUserMenuAdditionSubtraction>();
        }

        public int ID { get; set; }

        public int? ParentMenuCode { get; set; }

        public int? ReportInfoCode { get; set; }

        public int? DashboardReportInfoCode { get; set; }

        public int? ReportLookupParamInfoCode { get; set; }

        public int? FormLookupParamInfoCode { get; set; }

        [StringLength(50)]
        public string RightType { get; set; }

        [StringLength(50)]
        public string MenuType { get; set; }

        [StringLength(50)]
        public string MenuLevelCode { get; set; }

        [StringLength(255)]
        public string MenuTitle { get; set; }

        [StringLength(255)]
        public string MenuName { get; set; }

        [StringLength(510)]
        public string MenuCaption { get; set; }

        [StringLength(510)]
        public string MenuParentCaption { get; set; }

        [StringLength(255)]
        public string MenuShortKey { get; set; }

        [StringLength(1020)]
        public string BreadCrum { get; set; }

        [StringLength(255)]
        public string WinFormName { get; set; }

        [StringLength(255)]
        public string WebPageName { get; set; }

        [StringLength(510)]
        public string FormPageCaption { get; set; }

        [StringLength(1020)]
        public string WinPageParam { get; set; }

        [StringLength(1020)]
        public string WebPageParam { get; set; }

        [StringLength(1020)]
        public string URLPath { get; set; }

        [StringLength(1020)]
        public string RepositoryPath { get; set; }

        [StringLength(1020)]
        public string BOPath { get; set; }

        [StringLength(1020)]
        public string BALPath { get; set; }

        [StringLength(1020)]
        public string DALPath { get; set; }

        [StringLength(1020)]
        public string MVCPath { get; set; }

        [StringLength(255)]
        public string TblPKName { get; set; }

        [StringLength(255)]
        public string TblName { get; set; }

        public string TblDirectChild { get; set; }

        public string TblExclude { get; set; }

        [StringLength(1020)]
        public string PKArraryCodeCol { get; set; }

        [StringLength(1020)]
        public string PKArraryNameCol { get; set; }

        [StringLength(2040)]
        public string PKArraryAlias { get; set; }

        [StringLength(2040)]
        public string WhereClause { get; set; }

        [StringLength(50)]
        public string BGColorClass { get; set; }

        [StringLength(50)]
        public string FGCSSClass { get; set; }

        [StringLength(50)]
        public string CSSClass { get; set; }

        [StringLength(50)]
        public string IconClass { get; set; }

        [StringLength(2040)]
        public string EmailAddress { get; set; }

        [StringLength(2040)]
        public string MobileNo { get; set; }

        [StringLength(50)]
        public string RefNo { get; set; }

        public bool? IsEnforceReWrite { get; set; }

        public bool? IsModule { get; set; }

        public bool? IsDocument { get; set; }

        public bool? IsTransaction { get; set; }

        public DateTime? dtmExported { get; set; }

        public DateTime? dtmImported { get; set; }

        public DateTime dtmCreated { get; set; }

        public DateTime dtmLastM { get; set; }

        public int OwnerCode { get; set; }

        public int CreatedByCode { get; set; }

        public int AlteredByCode { get; set; }

        public byte RecordStatusCode { get; set; }

        public virtual BORecordStatus BORecordStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOTransactionDocumentProcess> BOTransactionDocumentProcess { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOActionLogging> BOActionLogging { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOAPPCNFDataLogging> BOAPPCNFDataLogging { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOCRMDataLogging> BOCRMDataLogging { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOErrorLogging> BOErrorLogging { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOFICODataLogging> BOFICODataLogging { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOHRMDataLogging> BOHRMDataLogging { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOIMMDataLogging> BOIMMDataLogging { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOSRMDataLogging> BOSRMDataLogging { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOUMSDataLogging> BOUMSDataLogging { get; set; }

        public virtual BOUser BOUser { get; set; }

        public virtual BOUser BOUser1 { get; set; }

        public virtual BOUser BOUser2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOMenuControlInfo> BOMenuControlInfo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOModuleColInfo> BOModuleColInfo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOModuleParamInfo> BOModuleParamInfo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOProfileGroupDetail> BOProfileGroupDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOReportDashboardInfo> BOReportDashboardInfo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOUser> BOUser3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOUserMenuAdditionSubtraction> BOUserMenuAdditionSubtraction { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOUserMenuAdditionSubtraction> BOUserMenuAdditionSubtraction1 { get; set; }
    }
}
