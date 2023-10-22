using System;

namespace HotelProjectWebUI.Dtos.SendMessageDto
{
    public class ResultSendBoxDto
    {
        public int SendMessageID { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public string ReceiverEmail { get; set; }
        public string SenderEmail { get; set; }
        public DateTime Date { get; set; }
    }
}
