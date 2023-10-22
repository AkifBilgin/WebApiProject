using System;

namespace HotelProjectWebUI.Dtos.SendMessageDto
{
    public class CreateSendMessageDto
    {
        public string Subject { get; set; }
        public string Message { get; set; }
        public string ReceiverEmail { get; set; }
        public string SenderEmail { get; set; }
        public DateTime Date { get; set; }
    }
}
