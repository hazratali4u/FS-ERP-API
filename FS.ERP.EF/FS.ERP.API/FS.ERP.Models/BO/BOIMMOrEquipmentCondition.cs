using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO
{
    [Table("AppCNF.tbl_IMMOrEquipmentCondition")]

    public partial class BOIMMOrEquipmentCondition
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOIMMOrEquipmentCondition()
        {
            this.BOGatePassDetail = new HashSet<BOGatePassDetail>();
            this.BOGRNandReturnDetail = new HashSet<BOGRNandReturnDetail>();
            this.BOPurchaseOrderAndReturnDetail = new HashSet<BOPurchaseOrderAndReturnDetail>();
            this.BOStockRequisitionOrIssuanceDetail = new HashSet<BOStockRequisitionOrIssuanceDetail>();
            this.BOStockRequisitionOrIssuanceDetail1 = new HashSet<BOStockRequisitionOrIssuanceDetail>();
            this.BOStockTakingAdjustmentDetail = new HashSet<BOStockTakingAdjustmentDetail>();
        }
    
        public byte ID { get; set; }
        public string ShortName { get; set; }
        public string FullName { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public byte SortOrder { get; set; }
        public Nullable<int> CompanyCode { get; set; }
        public Nullable<System.DateTime> dtmExported { get; set; }
        public Nullable<System.DateTime> dtmImported { get; set; }
        public System.DateTime dtmCreated { get; set; }
        public System.DateTime dtmLastM { get; set; }
        public int OwnerCode { get; set; }
        public int CreatedByCode { get; set; }
        public int AlteredByCode { get; set; }
        public byte RecordStatusCode { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOGatePassDetail> BOGatePassDetail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOGRNandReturnDetail> BOGRNandReturnDetail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOPurchaseOrderAndReturnDetail> BOPurchaseOrderAndReturnDetail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOStockRequisitionOrIssuanceDetail> BOStockRequisitionOrIssuanceDetail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOStockRequisitionOrIssuanceDetail> BOStockRequisitionOrIssuanceDetail1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOStockTakingAdjustmentDetail> BOStockTakingAdjustmentDetail { get; set; }
    }
}
