using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask.Core.Domain
{
    public class Doctor
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime HireDate { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int Salary { get; set; }
        public string Address { get; set; }
        [ForeignKey("Department")]
        public Guid DepartmentId { get; set; }
        public virtual Department Department { get; set; }
    }
}
