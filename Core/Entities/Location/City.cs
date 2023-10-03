/*

	Created By    : Eslam Elkhouly
	Modified By   :
	Created Data  : 12/06/2023
	Modified Date :
	Purpose       : Create Class City To Map City Tabel in Db


*/
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities.Location
{
    public class City
    {
        public int Id { get; set; }
        public string City_Name_AR { get; set; }

        public string? City_Name_EN { get; set; }
        public Governate Governate { get; set; }
        [ForeignKey("Governate")]
        public int GovernateId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
