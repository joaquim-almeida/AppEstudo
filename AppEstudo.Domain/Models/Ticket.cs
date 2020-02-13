﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace AppEstudo.Domain.Models
{
    public class Ticket
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public virtual TicketCategory Category { get; set; }
        public string Description { get; set; }
        public virtual TicketPriority Priority { get; set; }
        public virtual TicketStatus Status { get; set; }
        public DateTime Created { get; set; }
        public virtual User CreatedById { get; set; }
        public DateTime Modified { get; set; }
        public virtual User ModifiedById { get; set; }
    }
}
