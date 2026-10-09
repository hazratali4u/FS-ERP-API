using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO{
    [Table("Asset.tbl_Equipment")]
    public partial class BOEquipment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOEquipment()
        {
            BOBillOrInvoiceMasterDetail = new HashSet<BOBillOrInvoiceMasterDetail>();
            BOEmployeeLease = new HashSet<BOEmployeeLease>();
            BOGatePassDetail = new HashSet<BOGatePassDetail>();
            BOGatePass = new HashSet<BOGatePass>();
            BOGRNandReturnDetail = new HashSet<BOGRNandReturnDetail>();
            BOPurchaseOrderAndReturnDetail = new HashSet<BOPurchaseOrderAndReturnDetail>();
        }

        public long ID { get; set; }

        public long? lngCPRCode { get; set; }

        public byte OwnershipTypeCode { get; set; }

        public short EquipmentTypeCode { get; set; }

        public byte EquipmentStatusCode { get; set; }

        public int? CostOrProfitCenterCode { get; set; }

        public int? TransferCostOrProfitCenterCode { get; set; }

        public int? CurrentLocationCode { get; set; }

        public long? SoldToCustomerCode { get; set; }

        [StringLength(255)]
        public string SoldTo { get; set; }

        [StringLength(255)]
        public string ManufacturerOrMake { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ManufacturingYear { get; set; }

        [StringLength(50)]
        public string RegisterationNo { get; set; }

        [StringLength(50)]
        public string EngineNo { get; set; }

        [StringLength(50)]
        public string ChaisesNo { get; set; }

        [StringLength(50)]
        public string Model { get; set; }

        [StringLength(50)]
        public string Version { get; set; }

        [StringLength(50)]
        public string Color { get; set; }

        [Column(TypeName = "date")]
        public DateTime? InServiceDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? OutOfServiceDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? TransferDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? SoldDate { get; set; }

        public bool IsAttachedOrAllocated { get; set; }

        public bool? IsInRepairOrMaintenance { get; set; }

        public byte[] EquipmentImage { get; set; }

        public long? COACode { get; set; }

        public long? AccumulatedCOACode { get; set; }

        [StringLength(1020)]
        public string Description { get; set; }

        public int? CompanyCode { get; set; }

        public DateTime? dtmExported { get; set; }

        public DateTime? dtmImported { get; set; }

        public DateTime dtmCreated { get; set; }

        public DateTime dtmLastM { get; set; }

        public int OwnerCode { get; set; }

        public int CreatedByCode { get; set; }

        public int AlteredByCode { get; set; }

        public byte RecordStatusCode { get; set; }

        public virtual BOEquipmentStatus BOEquipmentStatus { get; set; }

        public virtual BOEquipmentType BOEquipmentType { get; set; }

        public virtual BOLocationSite BOLocationSite { get; set; }

        public virtual BOOnwerShipType BOOnwerShipType { get; set; }

        public virtual BOOrganizationCompany BOOrganizationCompany { get; set; }

        public virtual BOOrganizationCompany BOOrganizationCompany1 { get; set; }

        public virtual BOOrganizationCompany BOOrganizationCompany2 { get; set; }

        public virtual BORecordStatus BORecordStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOBillOrInvoiceMasterDetail> BOBillOrInvoiceMasterDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeLease> BOEmployeeLease { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOStockRequisitionOrIssuanceDetail> BOStockRequisitionOrIssuanceDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOStockRequisitionOrIssuanceDetail> BOStockRequisitionOrIssuanceDetail1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOGatePassDetail> BOGatePassDetail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOGatePass> BOGatePass { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOGRNandReturnDetail> BOGRNandReturnDetail { get; set; }

        public virtual BOCOA BOCOA { get; set; }

        public virtual BOCOA BOCOA1 { get; set; }

        public virtual BOPartyOrCustomer BOPartyOrCustomer { get; set; }

        public virtual BOUser BOUser { get; set; }

        public virtual BOUser BOUser1 { get; set; }

        public virtual BOUser BOUser2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOPurchaseOrderAndReturnDetail> BOPurchaseOrderAndReturnDetail { get; set; }
    }
}
