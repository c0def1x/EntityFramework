using System.ComponentModel.DataAnnotations;

namespace Entity_Framework.Models
{
    public class Blog
    {
        [Key]
        public string? Guid { get; set; }
        public string? Title { get; set; }
        public string? Author { get; set; }
        public DateTime CreationDate { get; set; }
        public List<Post>? Posts { get; set; }

        public Blog()
        {
            Guid = System.Guid.NewGuid().ToString();
        }
    }
}
