namespace PortfolioCoreDay.Entities
{
    public class Message
    {
        public int MessageId { get; set; }
        public String NameSurname { get; set; }
        public String Email { get; set; }
        public String Subject{ get; set; }
        public String MessageDetail{ get; set; }
        public DateTime SendDate{ get; set; }
        public bool Isread { get; set; }
       
    }
}
