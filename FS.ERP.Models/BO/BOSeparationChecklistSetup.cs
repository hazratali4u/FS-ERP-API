using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO
{
    [Table("HRM.tbl_SeparationChecklistSetup")]
    public partial class BOSeparationChecklistSetup
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOSeparationChecklistSetup()
        {
            this.BOSeparationCheckList = new HashSet<BOSeparationCheckList>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //[Key]
        public int ID { get; set; }
        public bool BaseCode { get; set; }
        public int DeptCode { get; set; }
        public string Description { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsLinkedWithAsset { get; set; }
        public Nullable<short> AssetCategoryCode { get; set; }
        public Nullable<int> DeptID { get; set; }
        public Nullable<long> SpecificEmployeeCode { get; set; }
        public int CompanyCode { get; set; }
        public Nullable<System.DateTime> dtmExported { get; set; }
        public Nullable<System.DateTime> dtmImported { get; set; }
        public System.DateTime dtmCreated { get; set; }
        public System.DateTime dtmLastM { get; set; }
        public int OwnerCode { get; set; }
        public int CreatedByCode { get; set; }
        public int AlteredByCode { get; set; }
        public byte RecordStatusCode { get; set; }

        public virtual BOEquipmentType BOEquipmentType { get; set; }
        public virtual BOOrganizationCompany BOOrganizationCompany { get; set; }
        public virtual BORecordStatus BORecordStatus { get; set; }
        public virtual BODepartment BODepartment { get; set; }
        public virtual BODepartment BODepartment1 { get; set; }
        public virtual BOEmployeeInfo BOEmployeeInfo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOSeparationCheckList> BOSeparationCheckList { get; set; }
    }
}
