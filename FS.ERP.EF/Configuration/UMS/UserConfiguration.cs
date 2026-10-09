using FS.ERP.Models.BO;
using FS.ERP.Models.IdentityModel;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.HRM
{
    public class UserConfiguration : EntityTypeConfiguration<BOUser>
    {
        public UserConfiguration()
        {

        }
    }
}
