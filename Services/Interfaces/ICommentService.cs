using Services.DTO;
using System.Collections.Generic;

namespace Services.Interfaces
{
    public interface ICommentService
    {
        void AddComment(CommentModelDTO model);
        List<CommentModelDTO> GetComments();
    }
}
