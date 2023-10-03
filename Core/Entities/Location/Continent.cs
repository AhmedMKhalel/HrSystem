/*

	Created By    : Eslam Elkhouly
	Modified By   :
	Created Data  : 12/06/2023
	Modified Date :
	Purpose       : Create Class Continent To Map Continent Tabel in Db


*/

namespace Core.Entities.Location
{
    public class Continent
    {
        public int Id { get; set; }
        public string Continent_Name_AR { get; set; }

        public string? Continent_Name_EN { get; set; }
        public bool IsDeleted { get; set; }
    }
}
