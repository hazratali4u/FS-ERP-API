using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO{
    [Table("AppCNF.tbl_AppConfigurationDetail")]
    public partial class BOAppConfigurationDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOAppConfigurationDetail()
        {
            BOAppConfigurationDetail1 = new HashSet<BOAppConfigurationDetail>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public int? TemplateDetailCode { get; set; }

        public int ApplicationConfigurationCode { get; set; }

        public short DataTypeCode { get; set; }

        [Required]
        [StringLength(255)]
        public string ColumnName { get; set; }

        [Required]
        public string ColumnValue { get; set; }

        [Required]
        public string ColumnValueList { get; set; }

        public string ColumnValueListName { get; set; }

        [StringLength(255)]
        public string TableName { get; set; }

        public long? TablePK { get; set; }

        [StringLength(1020)]
        public string TableColumnName { get; set; }

        public bool IsActive { get; set; }

        public bool IsTemplate { get; set; }

        public bool CanUserUpdate { get; set; }

        public bool? IsSystemUserBased { get; set; }

        [StringLength(1020)]
        public string Description { get; set; }

        public int CompanyCode { get; set; }

        public DateTime? dtmExported { get; set; }

        public DateTime? dtmImported { get; set; }

        public DateTime dtmCreated { get; set; }

        public DateTime dtmLastM { get; set; }

        public int OwnerCode { get; set; }

        public int CreatedByCode { get; set; }

        public int AlteredByCode { get; set; }

        public byte RecordStatusCode { get; set; }

        public virtual BOAppConfiguration BOAppConfiguration { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOAppConfigurationDetail> BOAppConfigurationDetail1 { get; set; }

        public virtual BOAppConfigurationDetail BOAppConfigurationDetail2 { get; set; }

        public virtual BODataType BODataType { get; set; }

        public virtual BOOrganizationCompany BOOrganizationCompany { get; set; }

        public virtual BORecordStatus BORecordStatus { get; set; }

        public virtual BOUser BOUser { get; set; }

        public virtual BOUser BOUser1 { get; set; }

        public virtual BOUser BOUser2 { get; set; }
    }
}
