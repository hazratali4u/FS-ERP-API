using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO{
    [Table("AppCNF.tbl_AttendanceMachineType")]
    public partial class BOAttendanceMachineType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOAttendanceMachineType()
        {
            BOAttendanceDiscrepancy = new HashSet<BOAttendanceDiscrepancy>();
            BOEmployeeAttendance = new HashSet<BOEmployeeAttendance>();
        }

        public short ID { get; set; }

        [Required]
        [StringLength(25)]
        public string IPAddress { get; set; }

        [Required]
        [StringLength(50)]
        public string MachineType { get; set; }

        [Required]
        [StringLength(510)]
        public string MachineName { get; set; }

        [StringLength(25)]
        public string IdentificationInType { get; set; }

        [StringLength(25)]
        public string IdentificationOutType { get; set; }

        [StringLength(25)]
        public string IdentificationDirection { get; set; }

        [StringLength(25)]
        public string IdentificationGroup { get; set; }

        [StringLength(50)]
        public string AccessControlInfo { get; set; }

        [StringLength(1020)]
        public string BackupLocation { get; set; }

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

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOAttendanceDiscrepancy> BOAttendanceDiscrepancy { get; set; }

        public virtual BOOrganizationCompany BOOrganizationCompany { get; set; }

        public virtual BORecordStatus BORecordStatus { get; set; }

        public virtual BOUser BOUser { get; set; }

        public virtual BOUser BOUser1 { get; set; }

        public virtual BOUser BOUser2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeAttendance> BOEmployeeAttendance { get; set; }
    }
}
