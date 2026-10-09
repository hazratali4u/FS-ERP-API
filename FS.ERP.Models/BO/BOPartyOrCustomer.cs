using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO{
    [Table("CRM.tbl_PartyOrCustomer")]
    public partial class BOPartyOrCustomer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOPartyOrCustomer()
        {
            BOPartyOrCustomerPlan = new HashSet<BOPartyOrCustomerPlan>();
            BOFreightEntrySlip = new HashSet<BOFreightEntrySlip>();
            BOCustomerReceipt = new HashSet<BOCustomerReceipt>();
            BOCustomerAdjustment = new HashSet<BOCustomerAdjustment>();
            //BOSaleInvoiceMaster = new HashSet<BOSaleInvoiceMaster>();
            BODeliveryNoteMaster = new HashSet<BODeliveryNoteMaster>();
            BOSaleOrderMaster = new HashSet<BOSaleOrderMaster>();
            BOLocationSite = new HashSet<BOLocationSite>();
            BOEquipment = new HashSet<BOEquipment>();
            BOBillOrInvoiceMaster = new HashSet<BOBillOrInvoiceMaster>();
            BOFundDemandRegisterDetail = new HashSet<BOFundDemandRegisterDetail>();
            BOFundDemandRequestDetail = new HashSet<BOFundDemandRequestDetail>();
            BOPartyOrCustomer1 = new HashSet<BOPartyOrCustomer>();
            BOPartyOrCustomer3 = new HashSet<BOPartyOrCustomer>();
            BOUserPartyOrCustomerPermission = new HashSet<BOUserPartyOrCustomerPermission>();
            BOLead = new HashSet<BOLead>();
            BOOpportunity = new HashSet<BOOpportunity>();
            BOPartyOrCustomerServiceType = new HashSet<BOPartyOrCustomerServiceType>();
            BOContacts = new HashSet<BOContacts>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public long ID { get; set; }
        public System.Guid UniqueID { get; set; }
        public Nullable<short> CustomerClass { get; set; }
        public Nullable<long> ParentCode { get; set; }
        public string ShortName { get; set; }
        public string FullName { get; set; }
        public string DisplayName { get; set; }
        public string RegistrationType { get; set; }
        public string Description { get; set; }
        public byte[] PartyOrCustomerLogo { get; set; }
        public string Salutation { get; set; }
        public Nullable<System.DateTime> EstablishDate { get; set; }
        public string UAN_No { get; set; }
        public string URL_Name { get; set; }
        public string SNS_RegNo { get; set; }
        public string NTN_No { get; set; }
        public string GST_No { get; set; }
        public Nullable<long> COACode { get; set; }
        public Nullable<decimal> OpeningBalance { get; set; }
        public Nullable<int> CreditDays { get; set; }
        public Nullable<int> GraceDays { get; set; }
        public Nullable<decimal> CreditAmount { get; set; }
        public Nullable<short> DefaultCultureCode { get; set; }
        public Nullable<short> DefaultCurrencyCode { get; set; }
        public string BusinessCategory { get; set; }
        public string RefferedBy { get; set; }
        public string CategroyType { get; set; }
        public string AuthorityType { get; set; }
        public string PriceLevel { get; set; }
        public string PreferredPaymentMethod { get; set; }
        public string PreferredDeliveryMethod { get; set; }
        public string PartySource { get; set; }
        public string PartySourceValue { get; set; }
        public Nullable<int> CityTownCode { get; set; }
        public Nullable<int> DistrictWardCode { get; set; }
        //public System.Data.Entity.Spatial.DbGeography GeoCode { get; set; }
        public Nullable<decimal> Longitude { get; set; }
        public Nullable<decimal> Latitude { get; set; }
        public Nullable<decimal> Altitude { get; set; }
        public Nullable<decimal> Radius { get; set; }
        public string PostalZipCode { get; set; }
        public string OfficialAddress { get; set; }
        public string OfficialPhoneNo { get; set; }
        public string PhoneExt { get; set; }
        public string FaxNo { get; set; }
        public string OfficialEmail { get; set; }
        public string WhatsAppNo { get; set; }
        public string OfficialMobileNo { get; set; }
        public int CompanyCode { get; set; }
        public Nullable<System.DateTime> dtmExported { get; set; }
        public Nullable<System.DateTime> dtmImported { get; set; }
        public System.DateTime dtmCreated { get; set; }
        public System.DateTime dtmLastM { get; set; }
        public int OwnerCode { get; set; }
        public int CreatedByCode { get; set; }
        public int AlteredByCode { get; set; }
        public long? BranchParentCode { get; set; }
        public byte RecordStatusCode { get; set; }
        public Nullable<long> CustomerTypeCode { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOContacts> BOContacts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOFundDemandRegisterDetail> BOFundDemandRegisterDetail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOFundDemandRequestDetail> BOFundDemandRequestDetail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOPartyOrCustomer> BOPartyOrCustomer1 { get; set; }
        public virtual ICollection<BOPartyOrCustomer> BOPartyOrCustomer3 { get; set; }
        public virtual BOPartyOrCustomer BOPartyOrCustomer2 { get; set; }
        public virtual BOPartyOrCustomer BOPartyOrCustomer4 { get; set; }
        public virtual BOUser BOUser { get; set; }
        public virtual BOUser BOUser1 { get; set; }
        public virtual BOUser BOUser2 { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOUserPartyOrCustomerPermission> BOUserPartyOrCustomerPermission { get; set; }



        //public long ID { get; set; }

        //public Guid UniqueID { get; set; }

        //public long? ParentCode { get; set; }

        //[StringLength(25)]
        //public string ShortName { get; set; }

        //[Required]
        //[StringLength(255)]
        //public string FullName { get; set; }

        //[StringLength(510)]
        //public string DisplayName { get; set; }

        //[StringLength(1020)]
        //public string Description { get; set; }

        //public byte[] PartyOrCustomerLogo { get; set; }

        //[Column(TypeName = "date")]
        //public DateTime? EstablishDate { get; set; }

        //[StringLength(50)]
        //public string UAN_No { get; set; }

        //[StringLength(50)]
        //public string URL_Name { get; set; }

        //[StringLength(50)]
        //public string SNS_RegNo { get; set; }

        //[StringLength(50)]
        //public string NTN_No { get; set; }

        //[StringLength(50)]
        //public string GST_No { get; set; }

        //public long? COACode { get; set; }

        //[Column(TypeName = "date")]
        //public DateTime? DOO { get; set; }

        //[Column(TypeName = "numeric")]
        //public decimal? OpeningBalance { get; set; }

        //public int? CreditDays { get; set; }

        //public int? GraceDays { get; set; }

        //[Column(TypeName = "numeric")]
        //public decimal? CreditAmount { get; set; }

        //public short? DefaultCultureCode { get; set; }

        //public short? DefaultCurrencyCode { get; set; }

        //[StringLength(50)]
        //public string BusinessCategory { get; set; }

        //[StringLength(50)]
        //public string CategroyType { get; set; }

        //[StringLength(50)]
        //public string AuthorityType { get; set; }

        //[StringLength(50)]
        //public string PriceLevel { get; set; }

        //[StringLength(50)]
        //public string PreferredPaymentMethod { get; set; }

        //[StringLength(50)]
        //public string PreferredDeliveryMethod { get; set; }

        //[StringLength(50)]
        //public string PartySource { get; set; }

        //[StringLength(50)]
        //public string PartySourceValue { get; set; }

        //public int? CityTownCode { get; set; }

        //public int? DistrictWardCode { get; set; }

        //public DbGeography GeoCode { get; set; }

        //[Column(TypeName = "numeric")]
        //public decimal? Longitude { get; set; }

        //[Column(TypeName = "numeric")]
        //public decimal? Latitude { get; set; }

        //[Column(TypeName = "numeric")]
        //public decimal? Altitude { get; set; }

        //[Column(TypeName = "numeric")]
        //public decimal? Radius { get; set; }

        //[StringLength(15)]
        //public string PostalZipCode { get; set; }

        //[StringLength(510)]
        //public string OfficialAddress { get; set; }

        //[StringLength(50)]
        //public string OfficialPhoneNo { get; set; }

        //[StringLength(7)]
        //public string PhoneExt { get; set; }

        //[StringLength(50)]
        //public string FaxNo { get; set; }

        //[StringLength(50)]
        //public string OfficialEmail { get; set; }

        //[StringLength(255)]
        //public string ContactPerson { get; set; }

        //[StringLength(50)]
        //public string ContactPersonCNIC { get; set; }

        //[StringLength(50)]
        //public string ContactPersonEmail { get; set; }

        //[StringLength(50)]
        //public string PersonalMobileNo { get; set; }

        //[StringLength(50)]
        //public string OfficialMobileNo { get; set; }

        //public int CompanyCode { get; set; }

        //public DateTime? dtmExported { get; set; }

        //public DateTime? dtmImported { get; set; }

        //public DateTime dtmCreated { get; set; }

        //public DateTime dtmLastM { get; set; }

        //public int OwnerCode { get; set; }

        //public int CreatedByCode { get; set; }

        //public int AlteredByCode { get; set; }

        //public byte RecordStatusCode { get; set; }

        //public Nullable<long> CustomerTypeCode { get; set; }

        public virtual BOCRMConfiguration BOCRMConfiguration { get; set; }

        public virtual BOCulture BOCulture { get; set; }

        public virtual BOCurrency BOCurrency { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOLead> BOLead { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOLocationSite> BOLocationSite { get; set; }

        public virtual BOOrganizationCompany BOOrganizationCompany { get; set; }

        public virtual BORecordStatus BORecordStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEquipment> BOEquipment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOBillOrInvoiceMaster> BOBillOrInvoiceMaster { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<BOFundDemandRegisterDetail> BOFundDemandRegisterDetail { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<BOFundDemandRequestDetail> BOFundDemandRequestDetail { get; set; }

        public virtual BOCityTown BOCityTown { get; set; }

        public virtual BOCOA BOCOA { get; set; }

        public virtual BODistrictWard BODistrictWard { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<BOPartyOrCustomer> BOPartyOrCustomer1 { get; set; }

        //public virtual BOPartyOrCustomer BOPartyOrCustomer2 { get; set; }

        //public virtual BOUser BOUser { get; set; }

        //public virtual BOUser BOUser1 { get; set; }

        //public virtual BOUser BOUser2 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<BOUserPartyOrCustomerPermission> BOUserPartyOrCustomerPermission { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOOpportunity> BOOpportunity { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOPartyOrCustomerServiceType> BOPartyOrCustomerServiceType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOSaleOrderMaster> BOSaleOrderMaster { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BODeliveryNoteMaster> BODeliveryNoteMaster { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<BOSaleInvoiceMaster> BOSaleInvoiceMaster { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOCustomerAdjustment> BOCustomerAdjustment { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOCustomerReceipt> BOCustomerReceipt { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOFreightEntrySlip> BOFreightEntrySlip { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOPartyOrCustomerPlan> BOPartyOrCustomerPlan { get; set; }

    }
}
