namespace FS.CAPI.BAL
{
    public abstract class CAPIBaseRepo
    {
        public string ConStr { get; set; }
        public CAPIBaseRepo(string conStr)
        {
            this.ConStr = conStr;
        }
    }
}
