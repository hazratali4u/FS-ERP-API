using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO{
    [Table("MenuCNF.tbl_ModuleColInfo")]
    public partial class BOModuleColInfo
    {
        public long ID { get; set; }

        public int MenuCode { get; set; }

        public int? MenuParamInfoCode { get; set; }

        public long? MenuControlInfoCode { get; set; }

        [StringLength(2040)]
        public string TableOrFunctionName { get; set; }

        [StringLength(1020)]
        public string ColName { get; set; }

        [StringLength(2040)]
        public string ColAliasName { get; set; }

        [StringLength(2040)]
        public string ColAliasNameUrdu { get; set; }

        [StringLength(2040)]
        public string ColAliasNameArabic { get; set; }

        [StringLength(3060)]
        public string ColProcOrVwName { get; set; }

        [StringLength(510)]
        public string ColumnValue { get; set; }

        public short? DataTypeCode { get; set; }

        public bool? IsDefault { get; set; }

        public bool? IsDefaultParam { get; set; }

        public bool? IsInSelection { get; set; }

        public bool? IsActive { get; set; }

        public DateTime? dtmExported { get; set; }

        public DateTime? dtmImported { get; set; }

        public DateTime dtmCreated { get; set; }

        public DateTime dtmLastM { get; set; }

        public int OwnerCode { get; set; }

        public int CreatedByCode { get; set; }

        public int AlteredByCode { get; set; }

        public byte RecordStatusCode { get; set; }

        public virtual BODataType BODataType { get; set; }

        public virtual BORecordStatus BORecordStatus { get; set; }

        public virtual BOMenu BOMenu { get; set; }

        public virtual BOMenuControlInfo BOMenuControlInfo { get; set; }

        public virtual BOModuleParamInfo BOModuleParamInfo { get; set; }

        public virtual BOUser BOUser { get; set; }

        public virtual BOUser BOUser1 { get; set; }

        public virtual BOUser BOUser2 { get; set; }
    }
}
