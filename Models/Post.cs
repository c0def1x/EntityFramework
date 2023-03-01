using System.ComponentModel.DataAnnotations;

namespace Entity_Framework.Models
{
    public class Post
    {
        [Key]
        public string? Guid { get; set; }
        public string? Title { get; set; }
        public string? Text { get; set; }
        public DateTime PublicationTime { get; set; }
        public bool IsPublished { get; set; }

        public Post()
        {
            Guid = System.Guid.NewGuid().ToString();
        }
    }
}
