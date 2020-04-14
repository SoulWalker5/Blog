using AutoMapper;
using BL.BLModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.App_Start
{
    public class WebAutomapperProfile : Profile
    {
        public WebAutomapperProfile()
        {
            CreateMap<CategoryModel, CategoryBL>().ReverseMap();
            CreateMap<CommentModel, CommentBL>().ReverseMap();
            CreateMap<ArticleModel, ArticleBL>().ReverseMap();
            CreateMap<UserModel, UserBL>().ReverseMap();
        }
    }
}