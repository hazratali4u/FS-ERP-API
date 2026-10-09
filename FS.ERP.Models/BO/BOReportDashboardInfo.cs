using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO{
    [Table("MenuCNF.tbl_ReportDashboardInfo")]
    public partial class BOReportDashboardInfo
    {
        public int ID { get; set; }

        public int MenuCode { get; set; }

        public int? NoOfPrint { get; set; }

        public bool? IsAutoPrint { get; set; }

        public bool? IsCrReport { get; set; }

        [StringLength(2040)]
        public string DashboardProcName { get; set; }

        [StringLength(2040)]
        public string SubReportProcName { get; set; }

        [StringLength(255)]
        public string DashboardName { get; set; }

        [StringLength(255)]
        public string ReportName { get; set; }

        [StringLength(2040)]
        public string DashboardNameInfo { get; set; }

        [StringLength(2040)]
        public string SubReportNameInfo { get; set; }

        [StringLength(510)]
        public string ReportCaption { get; set; }

        [StringLength(510)]
        public string ReportCaptionUrdu { get; set; }

        [StringLength(510)]
        public string ReportCaptionArabic { get; set; }

        [StringLength(1020)]
        public string ReportPath { get; set; }

        [StringLength(1020)]
        public string ReportParam { get; set; }

        [StringLength(1020)]
        public string ReportParamVal { get; set; }

        [StringLength(1020)]
        public string DefaultWhereClause { get; set; }

        [StringLength(1020)]
        public string DefaultSubWhereClause { get; set; }

        [StringLength(1020)]
        public string ReportSpecialText { get; set; }

        public short? ZoomLevel { get; set; }

        [StringLength(50)]
        public string DocRefNo { get; set; }

        public byte[] vbrReportImage { get; set; }

        public byte[] vbrDashboardFile { get; set; }

        public DateTime? dtmExported { get; set; }

        public DateTime? dtmImported { get; set; }

        public DateTime dtmCreated { get; set; }

        public DateTime dtmLastM { get; set; }

        public int OwnerCode { get; set; }

        public int CreatedByCode { get; set; }

        public int AlteredByCode { get; set; }

        public byte RecordStatusCode { get; set; }

        public virtual BORecordStatus BORecordStatus { get; set; }

        public virtual BOMenu BOMenu { get; set; }

        public virtual BOUser BOUser { get; set; }

        public virtual BOUser BOUser1 { get; set; }

        public virtual BOUser BOUser2 { get; set; }
    }
}
