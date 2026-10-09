using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.AppCNF
{
    public class LocationSiteConfiguration : EntityTypeConfiguration<BOLocationSite>
    {
        public LocationSiteConfiguration()
        {
            this
               .Property(e => e.MinHumidity)
               .HasPrecision(18, 7);

            this
                .Property(e => e.MaxHumidity)
                .HasPrecision(18, 7);

            this
                .Property(e => e.MinTemperature)
                .HasPrecision(18, 7);

            this
                .Property(e => e.MaxTemperature)
                .HasPrecision(18, 7);

            this
                .Property(e => e.Length)
                .HasPrecision(18, 7);

            this
                .Property(e => e.Width)
                .HasPrecision(18, 7);

            this
                .Property(e => e.Height)
                .HasPrecision(18, 7);

            this
                .Property(e => e.DiaMeter)
                .HasPrecision(18, 7);

            this
                .Property(e => e.OpenAreaLength)
                .HasPrecision(18, 7);

            this
                .Property(e => e.OpenAreaWidth)
                .HasPrecision(18, 7);

            this
                .Property(e => e.OpenAreaHeight)
                .HasPrecision(18, 7);

            this
                .HasMany(e => e.BOEmployeeInfo)
                .WithOptional(e => e.BOLocationSite)
                .HasForeignKey(e => e.CurrentLocationCode);

            this
                .HasMany(e => e.BOEmployeeInfo1)
                .WithOptional(e => e.BOLocationSite1)
                .HasForeignKey(e => e.ReportingLocationCode);

            this
                .HasMany(e => e.BOEmployeeInfoRevision)
                .WithOptional(e => e.BOLocationSite)
                .HasForeignKey(e => e.CurrentLocationCode);

            this
                .HasMany(e => e.BOEmployeeInfoRevision1)
                .WithOptional(e => e.BOLocationSite1)
                .HasForeignKey(e => e.ReportingLocationCode);

            this
                .HasMany(e => e.BOEmployeeSalary)
                .WithOptional(e => e.BOLocationSite)
                .HasForeignKey(e => e.CurrentLocationCode);

            this
                .HasMany(e => e.BOEquipment)
                .WithOptional(e => e.BOLocationSite)
                .HasForeignKey(e => e.CurrentLocationCode);

            this
                .HasMany(e => e.BOLocationSite1)
                .WithOptional(e => e.BOLocationSite2)
                .HasForeignKey(e => e.LocationSiteCode);

            this
                .HasMany(e => e.BOUser3)
                .WithOptional(e => e.BOLocationSite3)
                .HasForeignKey(e => e.DefaultLocationCode);

            this
                .HasMany(e => e.BOUserLocationSitePermission)
                .WithRequired(e => e.BOLocationSite)
                .HasForeignKey(e => e.LocationSiteCode)
                .WillCascadeOnDelete(false);

            this
               .HasMany(e => e.BOGatePass)
               .WithRequired(e => e.BOLocationSite)
               .HasForeignKey(e => e.LocationSiteCode)
               .WillCascadeOnDelete(false);

            this
               .HasMany(e => e.BOGRNandReturn)
               .WithOptional(e => e.BOLocationSite)
               .HasForeignKey(e => e.LocationSiteCode)
               .WillCascadeOnDelete(false);

            this
               .HasMany(e => e.BOProductionMaster)
               .WithRequired(e => e.BOLocationSite)
               .HasForeignKey(e => e.LocationSiteCode)
               .WillCascadeOnDelete(false);

            this
           .HasMany(e => e.BOTable)
           .WithRequired(e => e.BOLocationSite)
           .HasForeignKey(e => e.LocationSiteCode)
           .WillCascadeOnDelete(false);

            this
           .HasMany(e => e.BOTable1)
           .WithRequired(e => e.BOLocationSite1)
           .HasForeignKey(e => e.HallCode)
           .WillCascadeOnDelete(false);

             this.HasMany(e => e.BOLocationSiteWiseItem)
             .WithRequired(e => e.BOLocationSite)
             .HasForeignKey(e => e.LocationSiteCode)
             .WillCascadeOnDelete(false);

           this.HasMany(e => e.BOHall)
           .WithRequired(e => e.BOLocationSite)
           .HasForeignKey(e => e.LocationSiteCode)
           .WillCascadeOnDelete(false);
        }
    }
}
