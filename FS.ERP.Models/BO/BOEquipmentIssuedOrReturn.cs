using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO
{
    [Table("Asset.tbl_EquipmentIssuedOrReturn")]
    public partial class BOEquipmentIssuedOrReturn
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }
        public Nullable<int> BaseCode { get; set; }
        public long EquipmentCode { get; set; }
        public long EmpCode { get; set; }
        public Nullable<System.DateTime> IssuedOn { get; set; }
        public string Remarks { get; set; }
        public Nullable<int> CompanyCode { get; set; }
        public Nullable<System.DateTime> dtmExported { get; set; }
        public Nullable<System.DateTime> dtmImported { get; set; }
        public System.DateTime dtmCreated { get; set; }
        public System.DateTime dtmLastM { get; set; }
        public int OwnerCode { get; set; }
        public int CreatedByCode { get; set; }
        public int AlteredByCode { get; set; }
        public byte RecordStatusCode { get; set; }


        public virtual BOEmployeeInfo BOEmployeeInfo { get; set; }
        public virtual BOEquipment BOEquipment { get; set; }
        public virtual BOOrganizationCompany BOOrganizationCompany { get; set; }
        public virtual BORecordStatus BORecordStatus { get; set; }
        public virtual BOUser BOUser { get; set; }
        public virtual BOUser BOUser1 { get; set; } 
        public virtual BOUser BOUser2 { get; set; }
    }
}
