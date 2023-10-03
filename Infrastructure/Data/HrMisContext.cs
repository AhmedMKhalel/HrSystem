using Core.Entities.Staff;
using Core.Entities.Staff.GeneralStaff;
using Core.Entities.Staff.PrivateStaff;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Infrastructure.Data
{
    public class HrMisContext : DbContext
    {
        public HrMisContext(DbContextOptions<HrMisContext> options) : base(options)
        {

        }

        public DbSet<GeneralJobGradesGroups>? GeneralJobGradesGroups { get; set; }
        public DbSet<QualityGroup_GeneralJobGradesGroups>? QualityGroup_GeneralJobGradesGroups { get; set; }
        public DbSet<JobTitle_QualityGroup_GeneralJobGradesGroups>? JobTitle_QualityGroup_GeneralJobGradesGroups { get; set; }
        public DbSet<PrivateJobGradesGroups>? PrivateJobGradesGroups { get; set; }
        public DbSet<Staff>? Staff { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
