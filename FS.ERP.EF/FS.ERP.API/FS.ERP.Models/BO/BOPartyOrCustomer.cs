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
            BOLocationSite = new HashSet<BOLocationSite>();
            BOEquipment = new HashSet<BOEquipment>();
            BOBillOrInvoiceMaster = new HashSet<BOBillOrInvoiceMaster>();
            BOFundDemandRegisterDetail = new HashSet<BOFundDemandRegisterDetail>();
            BOFundDemandRequestDetail = new HashSet<BOFundDemandRequestDetail>();
            BOPartyOrCustomer1 = new HashSet<BOPartyOrCustomer>();
            BOUserPartyOrCustomerPermission = new HashSet<BOUserPartyOrCustomerPermission>();
            BOLead = new HashSet<BOLead>();
            BOOpportunity = new HashSet<BOOpportunity>();
            BOPartyOrCustomerServiceType = new HashSet<BOPartyOrCustomerServiceType>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID { get; set; }

        public Guid UniqueID { get; set; }

        public long? ParentCode { get; set; }

        [StringLength(25)]
        public string ShortName { get; set; }

        [Required]
        [StringLength(255)]
        public string FullName { get; set; }

        [Required]
        [StringLength(510)]
        public string DisplayName { get; set; }

        [StringLength(1020)]
        public string Description { get; set; }

        public byte[] PartyOrCustomerLogo { get; set; }

        [Column(TypeName = "date")]
        public DateTime? EstablishDate { get; set; }

        [StringLength(50)]
        public string UAN_No { get; set; }

        [StringLength(50)]
        public string URL_Name { get; set; }

        [StringLength(50)]
        public string SNS_RegNo { get; set; }

        [StringLength(50)]
        public string NTN_No { get; set; }

        [StringLength(50)]
        public string GST_No { get; set; }

        public long? COACode { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DOO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? OpeningBalance { get; set; }

        public int? CreditDays { get; set; }

        public int? GraceDays { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CreditAmount { get; set; }

        public short? DefaultCultureCode { get; set; }

        public short? DefaultCurrencyCode { get; set; }

        [StringLength(50)]
        public string BusinessCategory { get; set; }

        [StringLength(50)]
        public string CategroyType { get; set; }

        [StringLength(50)]
        public string AuthorityType { get; set; }

        [StringLength(50)]
        public string PriceLevel { get; set; }

        [StringLength(50)]
        public string PreferredPaymentMethod { get; set; }

        [StringLength(50)]
        public string PreferredDeliveryMethod { get; set; }

        [StringLength(50)]
        public string PartySource { get; set; }

        [StringLength(50)]
        public string PartySourceValue { get; set; }

        public int? CityTownCode { get; set; }

        public int? DistrictWardCode { get; set; }

        public DbGeography GeoCode { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Longitude { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Latitude { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Altitude { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Radius { get; set; }

        [StringLength(15)]
        public string PostalZipCode { get; set; }

        [StringLength(510)]
        public string OfficialAddress { get; set; }

        [StringLength(50)]
        public string OfficialPhoneNo { get; set; }

        [StringLength(7)]
        public string PhoneExt { get; set; }

        [StringLength(50)]
        public string FaxNo { get; set; }

        [StringLength(50)]
        public string OfficialEmail { get; set; }

        [StringLength(255)]
        public string ContactPerson { get; set; }

        [StringLength(50)]
        public string ContactPersonCNIC { get; set; }

        [StringLength(50)]
        public string ContactPersonEmail { get; set; }

        [StringLength(50)]
        public string PersonalMobileNo { get; set; }

        [StringLength(50)]
        public string OfficialMobileNo { get; set; }

        public int CompanyCode { get; set; }

        public DateTime? dtmExported { get; set; }

        public DateTime? dtmImported { get; set; }

        public DateTime dtmCreated { get; set; }

        public DateTime dtmLastM { get; set; }

        public int OwnerCode { get; set; }

        public int CreatedByCode { get; set; }

        public int AlteredByCode { get; set; }

        public byte RecordStatusCode { get; set; }

        public Nullable<long> CustomerTypeCode { get; set; }

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

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOFundDemandRegisterDetail> BOFundDemandRegisterDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOFundDemandRequestDetail> BOFundDemandRequestDetail { get; set; }

        public virtual BOCityTown BOCityTown { get; set; }

        public virtual BOCOA BOCOA { get; set; }

        public virtual BODistrictWard BODistrictWard { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOPartyOrCustomer> BOPartyOrCustomer1 { get; set; }

        public virtual BOPartyOrCustomer BOPartyOrCustomer2 { get; set; }

        public virtual BOUser BOUser { get; set; }

        public virtual BOUser BOUser1 { get; set; }

        public virtual BOUser BOUser2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOUserPartyOrCustomerPermission> BOUserPartyOrCustomerPermission { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOOpportunity> BOOpportunity { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOPartyOrCustomerServiceType> BOPartyOrCustomerServiceType { get; set; }
    }
}
