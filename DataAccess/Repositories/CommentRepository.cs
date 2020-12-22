using DataAccess.EF.Entityes;
using DataAccess.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Repositories
{
    public class CommentRepository : ICommentRepository
    {
        private DataAccess.EF.AppContext db = new DataAccess.EF.AppContext();

        public void AddComment(Comment comment)
        {
            db.Comments.Add(comment);
            db.SaveChanges();
        }

        public List<Comment> GetAll() => db.Comments.ToList();
    }
}
