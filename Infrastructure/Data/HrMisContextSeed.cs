using Core.Entities.Staff;
using Core.Entities.Staff.GeneralStaff;
using Core.Entities.Staff.PrivateStaff;
using Microsoft.Extensions.Logging;
using System.Text.Json;

namespace Infrastructure.Data
{
    public class HrMisContextSeed
    {
        public static async Task SeedAsync(HrMisContext context, ILoggerFactory loggerFactory)
        {
            try
            {
                #region Seeding Data To GeneralJobGradesGroups Table In Db.

                if (context.GeneralJobGradesGroups != null && !context.GeneralJobGradesGroups.Any())
                {
                    var groupsData = File.ReadAllText("../Infrastructure/Data/SeedData/Staff/GeneralStaff/GeneralJobGradesGroups.json");
                    var options = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };

                    var groups = JsonSerializer.Deserialize<List<GeneralJobGradesGroups>>(groupsData);

                    foreach (var group in groups)
                    {
                        group.DateOfCreation = DateTime.Now;
                        context.GeneralJobGradesGroups.Add(group);
                    }

                    await context.SaveChangesAsync();
                }
                #endregion

                #region Seeding Data To QualityGroup_GeneralJobGradesGroups Table In Db.

                if (context.QualityGroup_GeneralJobGradesGroups != null && !context.QualityGroup_GeneralJobGradesGroups.Any())
                {
                    var qualityGroupData = File.ReadAllText("../Infrastructure/Data/SeedData/Staff/GeneralStaff/QualityGroup_GeneralJobGradesGroups.json");
                    var options = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };
                    var qualityGroups = JsonSerializer.Deserialize<List<QualityGroup_GeneralJobGradesGroups>>(qualityGroupData);

                    foreach (var group in qualityGroups)
                    {
                        group.DateOfCreation = DateTime.Now;
                        context.QualityGroup_GeneralJobGradesGroups.Add(group);
                    }

                    await context.SaveChangesAsync();
                }

                #endregion

                #region Seeding Data To JobTitle_QualityGroup_GeneralJobGradesGroups Table In Db.


                if (context.JobTitle_QualityGroup_GeneralJobGradesGroups != null && !context.JobTitle_QualityGroup_GeneralJobGradesGroups.Any())
                {
                    var jobTitleGroupData = File.ReadAllText("../Infrastructure/Data/SeedData/Staff/GeneralStaff/JobTitle_QualityGroup_GeneralJobGradesGroups.json");
                    var options = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };
                    var jobTitleGroup = JsonSerializer.Deserialize<List<JobTitle_QualityGroup_GeneralJobGradesGroups>>(jobTitleGroupData);

                    foreach (var group in jobTitleGroup)
                    {
                        group.DateOfCreation = DateTime.Now;
                        context.JobTitle_QualityGroup_GeneralJobGradesGroups.Add(group);
                    }

                    await context.SaveChangesAsync();
                }
                #endregion

                #region Seeding Data To PrivateJobGradesGroups Table In Db.


                if (context.PrivateJobGradesGroups != null && !context.PrivateJobGradesGroups.Any())
                {
                    var PrivateGroupsData = File.ReadAllText("../Infrastructure/Data/SeedData/Staff/PrivateStaff/PrivateJobGradesGroups.json");
                    var options = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };
                    var PrivateGroup = JsonSerializer.Deserialize<List<PrivateJobGradesGroups>>(PrivateGroupsData);

                    foreach (var group in PrivateGroup)
                    {
                        group.DateOfCreation = DateTime.Now;
                        context.PrivateJobGradesGroups.Add(group);
                    }

                    await context.SaveChangesAsync();
                }
                #endregion

                #region Seeding Data To Staff Table In Db.

                if (context.Staff != null && !context.Staff.Any())
                {
                    var staffData = File.ReadAllText("../Infrastructure/Data/SeedData/Staff/Staff.json");
                    var options = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };

                    var staffGroups = JsonSerializer.Deserialize<List<Staff>>(staffData);

                    foreach (var group in staffGroups)
                    {
                        group.DateOfCreation = DateTime.Now;
                        context.Staff.Add(group);
                    }

                    await context.SaveChangesAsync();
                }
                #endregion



            }
            catch (Exception ex)
            {
                var logger = loggerFactory.CreateLogger<HrMisContextSeed>();
                logger.LogError(ex.Message, "Error");
            }
        }
    }
}