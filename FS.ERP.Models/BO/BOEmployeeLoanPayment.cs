using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO
{
    [Table("HRM.tbl_EmployeeLoanPayment")]
    public partial class BOEmployeeLoanPayment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }
        public Nullable<bool> PaymentType { get; set; }
        public long EmpCode { get; set; }
        public long EmployeeLoanCode { get; set; }
        public Nullable<byte> PaymentMode { get; set; }
        public long? COACode { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public string ChequeNo { get; set; }
        public Nullable<System.DateTime> ChequeIssuanceDate { get; set; }
        public Nullable<System.DateTime> ChequeRealizationDate { get; set; }
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


        public virtual BOEmployeeInfo BOEmployeeInfo { get; set; }
        public virtual BOOrganizationCompany BOOrganizationCompany { get; set; }
        public virtual BORecordStatus BORecordStatus { get; set; }
        public virtual BOUser BOUser { get; set; }
        public virtual BOUser BOUser1 { get; set; }
        public virtual BOUser BOUser2 { get; set; }
    }
}
