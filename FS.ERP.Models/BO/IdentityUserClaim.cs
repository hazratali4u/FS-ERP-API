using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO{
    [Table("security.IdentityUserClaim")]
    public partial class IdentityUserClaim
    {
        public int Id { get; set; }

        public int? UserId { get; set; }

        public string ClaimType { get; set; }

        public string ClaimValue { get; set; }

        public virtual IdentityUser IdentityUser { get; set; }
    }
}
