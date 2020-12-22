using System;
using System.ComponentModel.DataAnnotations;

namespace TaskElinext.Models
{
    public class CommentViewModel
    {
        public int Id { get; set; }
        public string Username { get; set; }
        [Required]
        public string Text { get; set; }
        public DateTime CreateDate { get; set; }
        public int? ParentId { get; set; }
    }
}