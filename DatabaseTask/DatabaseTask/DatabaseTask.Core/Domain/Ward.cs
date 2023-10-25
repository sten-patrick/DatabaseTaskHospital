using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask.Core.Domain
{
    public class Ward
    {
        [Key]
        public Guid Id { get; set; }
        public string Description { get; set; }
        public int RoomNr { get; set; }

        // Navigation property to Patients
        public virtual ICollection<Patient> Patients { get; set; } = new List<Patient>();
    }
}