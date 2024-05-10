namespace DataContextLibrary.Models
{
    public class EventParticipant
    {
        public int Id { get; set; }
        public int EventsId { get; set; }
        public int ParticipantsId { get; set; }
        public Event Event { get; set; } = null!;
        public Participant Participant { get; set; } = null!;
    }
}
