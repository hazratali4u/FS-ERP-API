using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.Models.BO
{
    [Table("HRM.tbl_Bulletin")]
    public class BOBulletin
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }
        public System.Guid UniqueID { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime ExpiryDate { get; set; }
        public Nullable<int> SortOrder { get; set; }
        public bool IsActive { get; set; }
        public bool? IsSMS { get; set; }
        public bool? IsEmail { get; set; }
        public bool? IsMobileApp { get; set; }
        public string Title { get; set; }
        public string Location { get; set; }
        public string Department { get; set; }
        public string Employee { get; set; }
        public byte[] Content { get; set; }
        public long? EmpCode { get; set; }
        public long? CategoryCode { get; set; }
        public string Category { get; set; }
        public int CompanyCode { get; set; }
        public Nullable<System.DateTime> dtmExported { get; set; }
        public Nullable<System.DateTime> dtmImported { get; set; }
        public System.DateTime dtmCreated { get; set; }
        public System.DateTime dtmLastM { get; set; }
        public int OwnerCode { get; set; }
        public int CreatedByCode { get; set; }
        public int AlteredByCode { get; set; }
        public byte RecordStatusCode { get; set; }
        public virtual BOBulletinCommunicationCategory BOBulletinCommunicationCategory { get; set; }
        public virtual BOEmployeeInfo BOEmployeeInfo { get; set; }
    }
}
