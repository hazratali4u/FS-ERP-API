using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO
{
    [Table("IMM.tbl_StockRequisitionOrIssuance")]
    public partial class BOStockRequisitionOrIssuance
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOStockRequisitionOrIssuance()
        {
            this.BOStockRequisitionOrIssuance1 = new HashSet<BOStockRequisitionOrIssuance>();
            this.BOStockRequisitionOrIssuanceDetail = new HashSet<BOStockRequisitionOrIssuanceDetail>();
            this.BOProductionMaster = new HashSet<BOProductionMaster>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }
        public System.Guid UniqueID { get; set; }
        public long BaseCode { get; set; }
        public Nullable<int> LocationSiteCode { get; set; }
        public Nullable<int> IssuanceToLocationCode { get; set; }
        public Nullable<short> FiscalYearCode { get; set; }
        public Nullable<long> StockRequisitionOrIssuanceCode { get; set; }
        public string TransactionCode { get; set; }
        public string TransactionNo { get; set; }
        public string ManualSerialNo { get; set; }
        public System.DateTime RequisitionDate { get; set; }
        public Nullable<System.DateTime> IssuanceDelivery { get; set; }
        public int RequisitionByPcOrCcCode { get; set; }
        public Nullable<int> IssuanceToPcOrCcCode { get; set; }
        public int RequisitionByDepartmentCode { get; set; }
        public Nullable<int> IssuanceToDepartmentCode { get; set; }
        public Nullable<bool> IsClose { get; set; }
        public Nullable<bool> IsComplete { get; set; }
        public long RequisitionByEmpCode { get; set; }
        public Nullable<long> IssuanceToEmpCode { get; set; }
        public long? SaleOrderCode { get; set; }
        public long? JobCardCode { get; set; }
        public Nullable<bool> IsApproved { get; set; }
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
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOStockRequisitionOrIssuance> BOStockRequisitionOrIssuance1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOStockRequisitionOrIssuanceDetail> BOStockRequisitionOrIssuanceDetail { get; set; }

        public virtual BOStockRequisitionOrIssuance BOStockRequisitionOrIssuance2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOProductionMaster> BOProductionMaster { get; set; }
    }
}
