/*

	Created By    : Eslam Elkhouly
	Modified By   :
	Created Data  : 12/06/2023
	Modified Date :
	Purpose       : Create Class Country To Map Country Tabel in Db


*/
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities.Location
{
    public class Country
    {
        public int Id { get; set; }
        public string Country_Name_AR { get; set; }

        public string? Country_Name_EN { get; set; }

        public Nationality Nationality { get; set; }
        [ForeignKey("Nationality")]
        public int NationalityId { get; set; }

        public Continent Continent { get; set; }
        [ForeignKey("Continent")]
        public int ContinentId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
