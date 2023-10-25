using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Department
    {
        [Key]
        public Guid Id { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentType { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Doctor> Doctors { get; set; }
    }
}
