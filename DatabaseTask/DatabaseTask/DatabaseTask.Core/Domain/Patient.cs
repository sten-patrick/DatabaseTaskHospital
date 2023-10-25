using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Patient
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public Guid WardId { get; set; }
        [ForeignKey("WardId")]
        public Ward Ward { get; set; }
        public virtual ICollection<Stay> Stays { get; set; } = new List<Stay>();
    }
}
