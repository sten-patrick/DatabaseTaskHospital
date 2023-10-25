using DatabaseTask.Core.Domain;
using System;
using System.Collections.Generic;

namespace HospitalManagement.Core.Domain
{
    public class Hospital
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Department> Departments { get; set; } = new List<Department>();
        public virtual ICollection<Patient> Patients { get; set; } = new List<Patient>();
        public virtual ICollection<Doctor> Doctors { get; set; } = new List<Doctor>();
    }
}
