using AutoMapper;
using Services.DTO;
using TaskElinext.Models;

namespace TaskElinext.Configs
{
    public class AutoMapperConfig
    {
        public static MapperConfiguration CommentMapper = new MapperConfiguration(cfg => cfg.CreateMap<CommentModelDTO, CommentViewModel>().ReverseMap());
    }
}