namespace Core.Entities.Staff.GeneralStaff
{
    public class GeneralJobGradesGroups
    {
 
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<QualityGroup_GeneralJobGradesGroups> QualityGroups { get; set; } = new List<QualityGroup_GeneralJobGradesGroups>();
        public DateTime DateOfCreation { get; set; }

    }

}
