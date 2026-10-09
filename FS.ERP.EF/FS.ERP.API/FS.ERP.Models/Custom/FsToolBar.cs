using System;

namespace FS.ERP.Models.Custom
{
    public class FsToolBar
    {
        public int intCode { set; get; }
        public string strName { set; get; }
        public string strType { set; get; }
        public string strImageURL { set; get; }
        public string strNavigationURL { set; get; }
        public string strClickAction { set; get; }
        public DateTime dtmCreated { set; get; }
        public DateTime dtmLastM { set; get; }
    }
}
