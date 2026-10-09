using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO{
    [Table("HRM.tbl_DegreeInstitute")]
    public partial class BODegreeInstitute
    {
        public int ID { get; set; }

        [StringLength(25)]
        public string ShortName { get; set; }

        [Required]
        [StringLength(255)]
        public string FullName { get; set; }

        [Required]
        [StringLength(510)]
        public string DisplayName { get; set; }

        [Required]
        [StringLength(50)]
        public string TypeOfInstitute { get; set; }

        [StringLength(1020)]
        public string TypesOfDegreeCode { get; set; }

        public string Agreement { get; set; }

        [StringLength(1020)]
        public string Description { get; set; }

        public byte[] DegreeInstituteLogo { get; set; }

        [Column(TypeName = "date")]
        public DateTime? EstablishDate { get; set; }

        [StringLength(50)]
        public string UAN_No { get; set; }

        [StringLength(50)]
        public string URL_Name { get; set; }

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

        public int? CompanyCode { get; set; }

        public DateTime? dtmExported { get; set; }

        public DateTime? dtmImported { get; set; }

        public DateTime dtmCreated { get; set; }

        public DateTime dtmLastM { get; set; }

        public int OwnerCode { get; set; }

        public int CreatedByCode { get; set; }

        public int AlteredByCode { get; set; }

        public byte RecordStatusCode { get; set; }

        public virtual BOOrganizationCompany BOOrganizationCompany { get; set; }

        public virtual BORecordStatus BORecordStatus { get; set; }

        public virtual BOUser BOUser { get; set; }

        public virtual BOUser BOUser1 { get; set; }

        public virtual BOUser BOUser2 { get; set; }
    }
}
