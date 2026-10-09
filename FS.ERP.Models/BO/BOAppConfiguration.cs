using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO{
    [Table("AppCNF.tbl_AppConfiguration")]
    public partial class BOAppConfiguration
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOAppConfiguration()
        {
            BOAppConfiguration1 = new HashSet<BOAppConfiguration>();
            BOAppConfigurationDetail = new HashSet<BOAppConfigurationDetail>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public short? DomainTypeCode { get; set; }

        public short DataTypeCode { get; set; }
        public int? ModuleCode { get; set; }

        public int? TemplateCode { get; set; }

        [StringLength(50)]
        public string ShortName { get; set; }

        [Required]
        [StringLength(510)]
        public string Name { get; set; }

        [Required]
        [StringLength(1020)]
        public string DisplayName { get; set; }

        [Required]
        public string DefaultValue { get; set; }

        public string ValueList { get; set; }

        [StringLength(1020)]
        public string TableColumnName { get; set; }

        public long? TablePK { get; set; }

        public string ValueListName { get; set; }

        public bool IsTemplate { get; set; }

        public bool IsRequiredOnFirstRun { get; set; }

        public bool CanUserUpdate { get; set; }

        public bool? IsSystemUserBased { get; set; }

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
        public virtual ICollection<BOAppConfiguration> BOAppConfiguration1 { get; set; }

        public virtual BOAppConfiguration BOAppConfiguration2 { get; set; }

        public virtual BODataType BODataType { get; set; }

        public virtual BODomainType BODomainType { get; set; }

        public virtual BOOrganizationCompany BOOrganizationCompany { get; set; }

        public virtual BORecordStatus BORecordStatus { get; set; }

        public virtual BOUser BOUser { get; set; }

        public virtual BOUser BOUser1 { get; set; }

        public virtual BOUser BOUser2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOAppConfigurationDetail> BOAppConfigurationDetail { get; set; }
    }
}
