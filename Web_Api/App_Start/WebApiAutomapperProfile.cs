using AutoMapper;
using BL.BLModel;
using Web_Api.Models;

namespace Web_Api.App_Start
{
    public class WebApiAutomapperProfile : Profile
    {
        public WebApiAutomapperProfile()
        {
            CreateMap<CategoryApiModel, CategoryBL>().ReverseMap();
            CreateMap<CommentApiModel, CommentBL>().ReverseMap();
            CreateMap<ArticleApiModel, ArticleBL>().ReverseMap();
            CreateMap<UserApiModel, UserBL>().ReverseMap();
        }
    }
}