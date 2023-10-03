
using System.ComponentModel.DataAnnotations.Schema;


namespace Core.Entities.Staff.GeneralStaff
{
    public class QualityGroup_GeneralJobGradesGroups

    {
     
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("GeneralJobGradesGroups")]
        public int GeneralJobGradesGroupsId { get; set; }
        public virtual GeneralJobGradesGroups GeneralJobGradesGroups { get; set; }
        public DateTime DateOfCreation { get; set; }

    }
}
