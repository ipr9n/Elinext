using System;

namespace DataAccess.EF.Entityes
{
    public class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string Username { get; set; }
        public DateTime CreateDate { get; set; }
        public int? ParentId { get; set; }
    }
}
