using System;

namespace Services.DTO
{
    public class CommentModelDTO
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string Username { get; set; }
        public DateTime CreateDate { get; set; }
        public int? ParentId { get; set; }
    }
}
