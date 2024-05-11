using System.ComponentModel.DataAnnotations.Schema;

namespace DataContextLibrary.Models
{
    [Table("Participants")]
    public class Participant
    {
        public Participant()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            Email = string.Empty;

            RegisteredEmail = string.Empty;
            Address1 = string.Empty;
            Address2 = string.Empty;
            City = string.Empty;
            State = string.Empty;

            FilePathCertificatePDF = string.Empty;
            FilePathCertificateJpg = string.Empty;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [NotMapped]
        public string FullName { get { return FirstName + " " + LastName; } }

        public List<Event> Events { get; set; }
        public string Email { get; set; }
        public string RegisteredEmail { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int? Zip { get; set; }
        public int? Phone { get; set; }
        public string? FilePathCertificatePDF { get; set; }
        public string? FilePathCertificateJpg { get; set; }
        public List<Certificates> Certificates { get; set; }


    }
}
