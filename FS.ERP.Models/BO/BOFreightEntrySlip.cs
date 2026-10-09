using FS.ERP.Models.IdentityModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.Models.BO
{
    [Table("SRM.tbl_FreightEntrySlip")]
    public class BOFreightEntrySlip
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }
        public string FolioNo { get; set; }
        public Nullable<long> CustomerCode { get; set; }
        public string ReferenceNumber { get; set; }
        public Nullable<long> SaleOrderCode { get; set; }
        public Nullable<long> DeliveryNoteCode { get; set; }
        public Nullable<decimal> FreightAmount { get; set; }
        public string DriveName { get; set; }
        public string DriverContact { get; set; }
        public string VehicleNo { get; set; }
        public string Remarks { get; set; }
        public int CompanyCode { get; set; }
        public Nullable<System.DateTime> dtmExported { get; set; }
        public Nullable<System.DateTime> dtmImported { get; set; }
        public System.DateTime dtmCreated { get; set; }
        public System.DateTime dtmLastM { get; set; }
        public int OwnerCode { get; set; }
        public int CreatedByCode { get; set; }
        public int AlteredByCode { get; set; }
        public byte RecordStatusCode { get; set; }

        public virtual BODeliveryNoteMaster BODeliveryNoteMaster { get; set; }
        public virtual BOPartyOrCustomer BOPartyOrCustomer {get;set;}
        public virtual BOOrganizationCompany BOOrganizationCompany { get; set; }
        public virtual BORecordStatus BORecordStatus { get; set; }
        public virtual BOUser BOUser { get; set; }
        public virtual BOUser BOUser1 { get; set; }
        public virtual BOUser BOUser2 { get; set; }
    }
}
