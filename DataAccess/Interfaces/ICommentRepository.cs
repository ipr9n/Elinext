using DataAccess.EF.Entityes;
using System.Collections.Generic;

namespace DataAccess.Interfaces
{
    public interface ICommentRepository
    {
        List<Comment> GetAll();
        void AddComment(Comment comment);
    }
}
