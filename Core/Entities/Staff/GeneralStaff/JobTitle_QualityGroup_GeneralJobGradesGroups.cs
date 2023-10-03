
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities.Staff.GeneralStaff
{
    public class JobTitle_QualityGroup_GeneralJobGradesGroups
    {
    
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("QualityGroup_GeneralJobGradesGroups")]
        public int QualityGroup_GeneralJobGradesGroupsId { get; set; }
        public virtual QualityGroup_GeneralJobGradesGroups QualityGroup_GeneralJobGradesGroups { get; set; }
        public DateTime DateOfCreation { get; set; }

    }

}
