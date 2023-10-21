namespace HotelProjectWebUI.Dtos.AboutUsDto
{
    public class UpdateAboutUsDto
    {
        public int AboutUsID { get; set; }
        public string Titel1 { get; set; }
        public string Titel2 { get; set; }
        public string Content { get; set; }
        public int RoomCount { get; set; }
        public int StaffCount { get; set; }
        public int CustomerCount { get; set; }
    }
}
