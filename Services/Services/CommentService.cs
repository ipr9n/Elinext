using AutoMapper;
using DataAccess.EF.Entityes;
using DataAccess.Interfaces;
using DataAccess.Repositories;
using Services.Configs;
using Services.DTO;
using Services.Interfaces;

using System.Collections.Generic;

namespace Services.Services
{
    public class CommentService : ICommentService
    {
        private ICommentRepository _comments = new CommentRepository();
        private Mapper _mapper = new Mapper(AutoMapperConfig.CommentMapper);

        public void AddComment(CommentModelDTO model) => _comments.AddComment(_mapper.Map<Comment>(model));

        public List<CommentModelDTO> GetComments() => _mapper.Map<List<CommentModelDTO>>(_comments.GetAll());
    }
}
