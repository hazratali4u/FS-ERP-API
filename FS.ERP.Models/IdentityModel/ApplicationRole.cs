using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace FS.ERP.Models.IdentityModel
{
    public class ApplicationUserLogin : IdentityUserLogin<int> 
    {
        [Key]
        public int ApplicationUserLogin_Id { get; set; }
    }

    public class ApplicationUserClaim : IdentityUserClaim<int> { }

    public class ApplicationUserRole : IdentityUserRole<int> 
    {
        [Key]
        public string ApplicationUserRoles_Id { get; set; }
    }

    public class ApplicationRole : IdentityRole<int, ApplicationUserRole>, IRole<int>
    {
        public string Description { get; set; }

        public ApplicationRole() : base() 
        {
            //base.Id = Guid.NewGuid().ToString("N").ToUpper();
        }

        public ApplicationRole(string name)
            : this()
        {
            this.Name = name;
        }

        public ApplicationRole(string name, string description)
            : this(name)
        {
            this.Description = description;
        }

        public bool? IsSuperAdmin { get; set; }

        public bool? IsDeveloper { get; set; }

        public DateTime? dtmUpLoaded { get; set; }

        public DateTime? dtmDownLoaded { get; set; }

        public DateTime? dtmExported { get; set; }

        public DateTime? dtmImported { get; set; }

        public DateTime dtmCreated { get; set; }

        public DateTime dtmLastM { get; set; }

        public int OwnerCode { get; set; }

        public int CreatedByCode { get; set; }

        public int AlteredByCode { get; set; }

        public byte RecordStatusCode { get; set; }
    }
}
