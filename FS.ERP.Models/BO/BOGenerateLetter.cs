using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.Models.BO
{
    [Table("HRM.tbl_GenerateLetter")]
    public class BOGenerateLetter
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }
        public System.Guid UniqueID { get; set; }
        public string SerialNo { get; set; }
        public string Location { get; set; }
        public long LetterTemplateCode { get; set; }
        public long EmpCode { get; set; }
        public long SignatoryCode { get; set; }
        public int CompanyCode { get; set; }
        public Nullable<System.DateTime> dtmExported { get; set; }
        public Nullable<System.DateTime> dtmImported { get; set; }
        public System.DateTime dtmCreated { get; set; }
        public System.DateTime dtmLastM { get; set; }
        public int OwnerCode { get; set; }
        public int CreatedByCode { get; set; }
        public int AlteredByCode { get; set; }
        public byte RecordStatusCode { get; set; }

        public virtual BOEmployeeInfo BOEmployeeInfo { get; set; }
        public virtual BOEmployeeInfo BOEmployeeInfo1 { get; set; }
        public virtual BOLetterTemplates BOLetterTemplates { get; set; }
    }
}
