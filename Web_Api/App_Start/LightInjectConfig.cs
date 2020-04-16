using AutoMapper;
using BL.Service;
using LightInject;
using System.Collections.Generic;
using System.Reflection;
using BL;
using LightInject.Mvc;
using LightInject.WebApi;
using System;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Web_Api.App_Start
{
    public static class LightInjectConfig
    {
        public static void Configurate()
        {
            var container = new ServiceContainer();
            container.RegisterApiControllers(Assembly.GetExecutingAssembly());

            container.EnablePerWebRequestScope();

            var config = new MapperConfiguration(cfg => cfg.AddProfiles(
                  new List<Profile>() { new WebApiAutomapperProfile(), new BLAutomapperProfile() }));

            container.Register(c => config.CreateMapper());

            container = BLLightInjectConfiguration.Configuration(container);

            container.Register<IArticleService, ArticleService>();
            container.Register<IUserService, UserService>();
            container.Register<ICategoryService, CategoryService>();
            container.Register<ICommentService, CommentService>();


            container.EnableWebApi(GlobalConfiguration.Configuration);
        }
    }
}