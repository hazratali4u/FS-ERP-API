using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO
{
    [Table("IMM.tbl_GatePass")]
    public partial class BOGatePass
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOGatePass()
        {
            this.BOGatePass1 = new HashSet<BOGatePass>();
            this.BOGatePassDetail = new HashSet<BOGatePassDetail>();
            this.BOGRNandReturn = new HashSet<BOGRNandReturn>();
            this.BOGRNandReturnCheckList = new HashSet<BOGRNandReturnCheckList>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }
        public System.Guid UniqueID { get; set; }
        public long BaseCode { get; set; }
        public Nullable<int> LocationSiteCode { get; set; }
        public Nullable<short> FiscalYearCode { get; set; }
        public Nullable<byte> DispatchReceiveMediumCode { get; set; }
        public Nullable<long> GatePassCode { get; set; }
        public Nullable<long> DeliveryNoteCode { get; set; }
        public Nullable<long> CustomerCode { get; set; }
        public Nullable<long> POCode { get; set; }
        public string TransactionCode { get; set; }
        public string TransactionNo { get; set; }
        public string ManualSerialNo { get; set; }
        public string BiltyOrDCNo { get; set; }
        public System.DateTime TransactionDate { get; set; }
        public Nullable<long> VendorOrSupplierCode { get; set; }
        //public string VendorOrSupplierName { get; set; }
        public Nullable<long> EquipmentCode { get; set; }
        public string EquipmentNo { get; set; }
        public string VehicleNo { get; set; }
        public string PersonOrDriverName { get; set; }
        public string DriverContact { get; set; }
        public Nullable<decimal> FreightAmount { get; set; }
        public Nullable<decimal> ODOReading { get; set; }
        public Nullable<decimal> FuelinTank { get; set; }
        //public Nullable<bool> IsInwardGP { get; set; }
        public Nullable<bool> IsClose { get; set; }
        public Nullable<bool> IsComplete { get; set; }
        public Nullable<short> CurrencyCode { get; set; }
        public Nullable<decimal> ExchangeRate { get; set; }
        public Nullable<decimal> MiscExpense { get; set; }
        public long GeneratedByEmpCode { get; set; }
        public Nullable<long> InspectedByEmpCode { get; set; }
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
        public virtual ICollection<BOGatePass> BOGatePass1 { get; set; }
        public virtual BOGatePass BOGatePass2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOGatePassDetail> BOGatePassDetail { get; set; }
        public virtual BOCurrency BOCurrency { get; set; }
        public virtual BOLocationSite BOLocationSite { get; set; }
        public virtual BOEquipment BOEquipment { get; set; }
        public virtual BOFiscalYear BOFiscalYear { get; set; }
        public virtual BODispatchReceiveMedium BODispatchReceiveMedium { get; set; }
        public virtual BOEmployeeInfo BOEmployeeInfo { get; set; }
        public virtual BOEmployeeInfo BOEmployeeInfo1 { get; set; }
        public virtual BOVendorOrSupplier BOVendorOrSupplier { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOGRNandReturn> BOGRNandReturn { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOGRNandReturnCheckList> BOGRNandReturnCheckList { get; set; }


    }
}
