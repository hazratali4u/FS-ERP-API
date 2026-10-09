using System;
using System.Collections.Generic;
using FS.ERP.Models.BO;

namespace FS.ERP.Models.Custom
{
    public class ProfileGroupDetails
    {
        public int ID { get; set; }
        public string ShortName { get; set; }
        public int MenuCode { get; set; }

        public int CodeMenu { get; set; }
        public string SecurityRightCode { get; set; }
        public int ProfileGroupCode { get; set; }
        public int ProfileGroupDetailID { get; set; }
        public string MenuType { get; set; }
        public string MenuLevelCode { get; set; }
        public string ParentMenuCode { get; set; }
        public string RightCaption { get; set; }
        public string RightSummary { get; set; }
        public string MenuName { get; set; }
        public string MenuTitle { get; set; }
        public string MenuCaption { get; set; }

        public DateTime dtmLastM { get; set; }
        public bool CanCall { get; set; }
        public bool CanNew { get; set; }
        public bool CanEdit { get; set; }
        public bool CanDelete { get; set; }
        public bool CanEmail { get; set; }
        public bool CanExport { get; set; }
        public bool CanFax { get; set; }
        public bool CanFind { get; set; }
        public bool CanPreview { get; set; }
        public bool CanPrint { get; set; }
        public bool CanSMS { get; set; }
        public bool CanVoid { get; set; }


        public string FullName { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public bool IsDisabled { get; set; }

    }

    //public class ProfileGroup
    //{
    //    public int ID { get; set; }
    //    public string ShortName { get; set; }
    //    public string FullName { get; set; }
    //    public string DisplayName { get; set; }
    //    public string Description { get; set; }
    //    public bool IsDisabled { get; set; }
    //    public int CompanyCode { get; set; }
    //    public DateTime dtmUploaded { get; set; }
    //    public DateTime dtmDownloaded { get; set; }
    //    public DateTime dtmCreated { get; set; }
    //    public DateTime dtmExported { get; set; }
    //    public DateTime dtmLastM { get; set; }
    //    public int OwnerCode { get; set; }
    //    public int CreatedByCode { get; set; }
    //    public int AleteredByCode { get; set; }
    //    public int RecordStatusCode { get; set; }
    //}

    public class GroupRolesDetail
    {
        public BOProfileGroup ProfileGroup { get; set; }
        public List<ProfileGroupDetails> ProfileMenuDetails { get; set; }
    }

}

