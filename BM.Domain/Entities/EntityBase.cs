using System;
namespace BM.Domain.Entities
{
    public abstract class EntityBase
    {
        public int Id { get; set; }

        public DateTime CreatedTime { get; set; }

        public DateTime UpdatedTime { get; set; }
    }
}
