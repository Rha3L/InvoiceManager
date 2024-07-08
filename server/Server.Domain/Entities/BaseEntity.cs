using System.ComponentModel.DataAnnotations;

namespace Server.Domain.Entities
{
    public abstract class BaseEntity
    {
        [Key]
        public int ID { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public bool IsActive { get; set; } = true;
    }
}
