using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorBlog.Shared
{
    public class BlogPost
    {
        public int Id { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "Please input Url under 20 chars")]
        public string Url { get; set; }
        [Required]        
        public string Title { get; set; }
        public string Content { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public bool IsPublished { get; set; } = true;
        public bool IsDeleted { get; set; } = false;
    }
}
