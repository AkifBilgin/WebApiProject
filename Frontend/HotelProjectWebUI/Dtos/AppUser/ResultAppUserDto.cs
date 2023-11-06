using HotelProjectEntityLayer.Concrete;

namespace HotelProjectWebUI.Dtos.AppUser
{
    public class ResultAppUserDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string ImageUrl { get; set; }
        public string WorkDepartment { get; set; }
        public int WorkLocationID { get; set; }
        public WorkLocation WorkLocation { get; set; }
    }
}
