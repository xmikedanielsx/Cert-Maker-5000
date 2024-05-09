﻿using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CertMaker5000.Data.Models
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
