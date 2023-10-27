using HotelProjectEntityLayer.Concrete;
using System;

namespace HotelProjectWebUI.Dtos.ContactDto
{
    public class CreateContactDto
    { 
        public string Name { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }
        public int MessageCategoryID { get; set; }
        public MessageCategory MessageCategory { get; set; }
    }
}
