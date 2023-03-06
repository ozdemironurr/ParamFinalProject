using Core.Entities;

namespace Entities.Concrete
{
    public class TopList : IEntity
    {
       
        public int ListId { get; set; }
        public int UserId { get; set; }
        public int CategoryId { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.Now;
        public DateTime CompletionDate { get; set; }

    }
}
