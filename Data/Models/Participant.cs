using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertMaker5000.Data.Models
{
    [Table("Participants")]
    public class Participant
    {
        public Participant()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            Email = string.Empty;
            FilePathCertificatePDF = string.Empty;
            FilePathCertificateJpg = string.Empty;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [NotMapped]
        public string FullName { get { return FirstName + " " + LastName;  } }

        public List<Event> Events { get; set; }
        public string Email { get; set; }
        public int? Phone { get; set; }
        public string? FilePathCertificatePDF { get; set; }
        public string? FilePathCertificateJpg { get; set; }


    }
}
