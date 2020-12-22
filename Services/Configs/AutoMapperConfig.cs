using AutoMapper;
using DataAccess.EF.Entityes;
using Services.DTO;

namespace Services.Configs
{
    public class AutoMapperConfig
    {
        public static MapperConfiguration CommentMapper = new MapperConfiguration(cfg => cfg.CreateMap<Comment, CommentModelDTO>().ReverseMap());
    }
}
