using AutoMapper;
using BL.BLModel;
using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class BLAutomapperProfile : Profile
    {
        public BLAutomapperProfile()
        {
            CreateMap<ArticleBL, Article>().ReverseMap();
            CreateMap<CategoryBL, Category>().ReverseMap();
            CreateMap<CommentBL, Comment>().ReverseMap();
            CreateMap<UserBL, User>().ReverseMap();
        }
    }
}
