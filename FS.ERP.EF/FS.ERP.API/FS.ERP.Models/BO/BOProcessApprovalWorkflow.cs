using System;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO{
    [Table("AppCNF.tbl_ProcessApprovalWorkflow")]
    public partial class BOProcessApprovalWorkflow
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public Guid UniqueID { get; set; }

        public int TransactionDocumentProcessCode { get; set; }

        public int? CostOrProfitCenterCode { get; set; }

        public int? DeptCode { get; set; }

        public short ApprovalAuthorityTypeCode { get; set; }

        public int SequenceNo { get; set; }

        public int CompanyCode { get; set; }

        public DateTime? dtmExported { get; set; }

        public DateTime? dtmImported { get; set; }

        public DateTime dtmCreated { get; set; }

        public DateTime dtmLastM { get; set; }

        public int OwnerCode { get; set; }

        public int CreatedByCode { get; set; }

        public int AlteredByCode { get; set; }

        public byte RecordStatusCode { get; set; }

        public virtual BOApprovalAuthorityType BOApprovalAuthorityType { get; set; }

        public virtual BOOrganizationCompany BOOrganizationCompany { get; set; }

        public virtual BOOrganizationCompany BOOrganizationCompany1 { get; set; }

        public virtual BODepartment BODepartment { get; set; }

        public virtual BORecordStatus BORecordStatus { get; set; }

        public virtual BOTransactionDocumentProcess BOTransactionDocumentProcess { get; set; }

        public virtual BOUser BOUser { get; set; }

        public virtual BOUser BOUser1 { get; set; }

        public virtual BOUser BOUser2 { get; set; }
    }
}
