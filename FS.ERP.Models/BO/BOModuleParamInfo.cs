using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO{
    [Table("MenuCNF.tbl_ModuleParamInfo")]
    public partial class BOModuleParamInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOModuleParamInfo()
        {
            BOMenuControlInfo = new HashSet<BOMenuControlInfo>();
            BOModuleColInfo = new HashSet<BOModuleColInfo>();
        }

        public int ID { get; set; }

        public int MenuCode { get; set; }

        public DateTime? dtmFrom { get; set; }

        public DateTime? dtmTo { get; set; }

        public DateTime? dtmCurrent { get; set; }

        [StringLength(50)]
        public string Code { get; set; }

        public bool? IsProcOrVw { get; set; }

        [StringLength(255)]
        public string EntityName { get; set; }

        [StringLength(255)]
        public string ProcName { get; set; }

        [StringLength(255)]
        public string DashboardProcName { get; set; }

        [StringLength(255)]
        public string VwName { get; set; }

        [StringLength(3060)]
        public string InSelection { get; set; }

        [StringLength(50)]
        public string TopRecords { get; set; }

        public string ColNameWithAlias { get; set; }

        public string ColNameWithAliasUrdu { get; set; }

        public string ColNameWithAliasArabic { get; set; }

        [StringLength(2040)]
        public string ColNameWithoutAlias { get; set; }

        [StringLength(2040)]
        public string ColNameWithoutAliasUrdu { get; set; }

        [StringLength(2040)]
        public string ColNameWithoutAliasArabic { get; set; }

        [StringLength(3060)]
        public string InnerColBaseOrderBy { get; set; }

        [StringLength(3060)]
        public string OuterAliasBaseOrderBy { get; set; }

        [StringLength(3060)]
        public string InnerColBaseGroupBy { get; set; }

        [StringLength(3060)]
        public string OuterColBaseGroupBy { get; set; }

        public string DefaultInnerColBaseWhereClause { get; set; }

        public string InnerColBaseWhereClause { get; set; }

        public string OuterAliasBaseWhereClause { get; set; }

        public string InnerColBaseHavingClause { get; set; }

        public string OuterAliasBaseHavingClause { get; set; }

        public int? PageIndex { get; set; }

        public long? PageSize { get; set; }

        public string ColsToHide { get; set; }

        [StringLength(2040)]
        public string ColsToFixed { get; set; }

        [StringLength(2040)]
        public string ColsToDate { get; set; }

        [StringLength(2040)]
        public string ColsToTime { get; set; }

        [StringLength(2040)]
        public string ColsToDateTime { get; set; }

        [StringLength(2040)]
        public string ColsToCount { get; set; }

        [StringLength(2040)]
        public string ColsToMax { get; set; }

        [StringLength(2040)]
        public string ColsToMin { get; set; }

        [StringLength(2040)]
        public string ColsToAvg { get; set; }

        public DateTime? dtmExported { get; set; }

        public DateTime? dtmImported { get; set; }

        public DateTime dtmCreated { get; set; }

        public DateTime dtmLastM { get; set; }

        public int OwnerCode { get; set; }

        public int CreatedByCode { get; set; }

        public int AlteredByCode { get; set; }

        public byte RecordStatusCode { get; set; }

        public virtual BORecordStatus BORecordStatus { get; set; }

        public virtual BOMenu BOMenu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOMenuControlInfo> BOMenuControlInfo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOModuleColInfo> BOModuleColInfo { get; set; }

        public virtual BOUser BOUser { get; set; }

        public virtual BOUser BOUser1 { get; set; }

        public virtual BOUser BOUser2 { get; set; }
    }
}
