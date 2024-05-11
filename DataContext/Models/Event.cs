using System.ComponentModel.DataAnnotations.Schema;

namespace DataContextLibrary.Models
{
    [Table("Events")]
    public class Event
    {
        public Event()
        {
            Name = string.Empty;
            Description = string.Empty;
            Address1 = string.Empty;
            Address2 = string.Empty;
            City = string.Empty;
            State = string.Empty;
            //FilePath = string.Empty;
        }
        public List<Participant> Participants { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int? Zip { get; set; }
        public string? FilePath { get; set; }
        public string? TemplateFilePath { get; set; }

    }
}
