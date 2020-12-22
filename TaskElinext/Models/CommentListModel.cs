using System.Collections.Generic;

namespace TaskElinext.Models
{
    public class CommentListModel
    {
        public int? Seed { get; set; }
        public List<CommentViewModel> Comments { get; set; }
    }
}