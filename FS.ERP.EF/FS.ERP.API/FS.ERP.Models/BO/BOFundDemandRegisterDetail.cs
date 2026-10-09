using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO{
    [Table("HRM.tbl_FundDemandRegisterDetail")]
    public partial class BOFundDemandRegisterDetail
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID { get; set; }

        public Guid UniqueID { get; set; }

        public long BaseCode { get; set; }

        public long FundDemandRegisterCode { get; set; }

        public long? FundDemandRequestCode { get; set; }

        public long? FundDemandRequestDetailCode { get; set; }

        public short? ExpenseTypeCode { get; set; }

        public long? JobProjectSchemeCode { get; set; }

        public long? CustomerPartyCode { get; set; }

        public long? COACode { get; set; }

        public short? TransactionLineNo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? RequestedAmount { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? lssuedAmount { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? UsedAmount { get; set; }

        [StringLength(2040)]
        public string Purpose { get; set; }

        public byte[] SupportingDocument { get; set; }

        public int CompanyCode { get; set; }

        public DateTime? dtmExported { get; set; }

        public DateTime? dtmImported { get; set; }

        public DateTime dtmCreated { get; set; }

        public DateTime dtmLastM { get; set; }

        public int OwnerCode { get; set; }

        public int CreatedByCode { get; set; }

        public int AlteredByCode { get; set; }

        public byte RecordStatusCode { get; set; }

        public virtual BOExpenseType BOExpenseType { get; set; }

        public virtual BOOrganizationCompany BOOrganizationCompany { get; set; }

        public virtual BORecordStatus BORecordStatus { get; set; }

        public virtual BOPartyOrCustomer BOPartyOrCustomer { get; set; }

        public virtual BOCOA BOCOA { get; set; }

        public virtual BOJobProjectScheme BOJobProjectScheme { get; set; }

        public virtual BOFundDemandRegister BOFundDemandRegister { get; set; }

        public virtual BOFundDemandRequest BOFundDemandRequest { get; set; }

        public virtual BOFundDemandRequestDetail BOFundDemandRequestDetail { get; set; }

        public virtual BOUser BOUser { get; set; }

        public virtual BOUser BOUser1 { get; set; }

        public virtual BOUser BOUser2 { get; set; }
    }
}
