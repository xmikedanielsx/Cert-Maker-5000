namespace DataContextLibrary.Models
{
    public class Certificates
    {
        public int Id { get; set; }
        public int ParticipanstId { get; set; }
        public string? FilePathImage { get; set; }
        public string? FilePathPDF { get; set; }
        public Participant Participant { get; set; }
    }
}
