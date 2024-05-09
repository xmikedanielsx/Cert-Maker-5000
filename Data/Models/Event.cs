using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertMaker5000.Data.Models
{
    [Table("Events")]
    public class Event
    {
        public Event()
        {
            Name = string.Empty;
            Description = string.Empty;
            //FilePath = string.Empty;
        }
        public List<Participant> Participants { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string? FilePath { get; set; }

    }
}
