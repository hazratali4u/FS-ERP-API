using System;
using System.Collections.Generic;

namespace FS.ERP.Models.Custom
{
    public class EmployeeUploadModel
    {
        public int ForRptng { get; set; }
        public int UserCode { get; set; }
        public int CompanyCode { get; set; }
        public List<EmployeeModel> employees { get; set; }
    }
    public class EmployeeModel
    {
        public string Salu { get; set; }
        public string FNm { get; set; }
        public string LNm { get; set; }
        public string FthNm { get; set; }
        public string Gndr { get; set; }
        public string ECd { get; set; }
        public string CNIC { get; set; }
        public DateTime? CNXDt { get; set; }
        public DateTime? DOB { get; set; }
        public string BldGr { get; set; }
        public string MSt { get; set; }
        public string Rlgn { get; set; }
        public string OEml { get; set; }
        public string OPh { get; set; }
        public string PEml { get; set; }
        public string PPh { get; set; }
        public string CAdd { get; set; }
        public string PAdd { get; set; }
        public string Cnty { get; set; }
        public string Cty { get; set; }
        public string SSN { get; set; }
        public DateTime? SSDt { get; set; }
        public string EBI { get; set; }
        public DateTime? EBDt { get; set; }
        public string PF { get; set; }
        public DateTime? PFDt { get; set; }
        public string PFOB { get; set; }
        public string AccT { get; set; }
        public string AccN { get; set; }
        public string BrCd { get; set; }
        public string IBAN { get; set; }
        public string BPay { get; set; }
        public string PbPrd { get; set; }
        public string NPrd { get; set; }
        public DateTime? DOJ { get; set; }
        public string HTyp { get; set; }
        public string RpEmp { get; set; }
        public string Loc { get; set; }
        public string BUnt { get; set; }
        public string VNtr { get; set; }
        public string Dpt { get; set; }
        public string Dsg { get; set; }
        public string Shf { get; set; }
        public string Grd { get; set; }
        public string Sal { get; set; }
        public string STrMd { get; set; }
        public string LvPol { get; set; }
        public string Zone { get; set; }
    }

    public class EmpResponse
    {
        public bool IsSuccess { get; set; }
        public List<EmpRespMsgs> EmpMsgs { get; set; }
    }

    public class EmpRespMsgs
    {
        public string EmpCode { get; set; }
        public string Status { get; set; }
        public string Msg { get; set; }
    }
}
