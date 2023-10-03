/*

	Created By    : Eslam Elkhouly
	Modified By   :
	Created Data  : 12/06/2023
	Modified Date :
	Purpose       : Create Class Nationality To Map Nationatiy Tabel in Db


*/
namespace Core.Entities.Location
{
    public class Nationality
    {
        public int Id { get; set; }
        public string Nationality_Name_AR { get; set; }
        
        public string? Nationality_Name_EN { get; set; }
        public bool IsDeleted { get; set; }
    }
}
