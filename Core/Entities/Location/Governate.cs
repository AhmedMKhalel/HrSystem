/*

	Created By    : Eslam Elkhouly
	Modified By   :
	Created Data  : 12/06/2023
	Modified Date :
	Purpose       : Create Class Governate To Map Governate Tabel in Db


*/
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities.Location
{
    public class Governate
    {
        public int Id { get; set; }
        public string Governate_Name_AR { get; set; }

        public string? Governate_Name_EN { get; set; }
        public int Governate_Code { get; set; }

        public Country Country { get; set; }

        [ForeignKey("Country")]
        public int CountryId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
