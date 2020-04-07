using AutoMapper;
using BL.Service;
using LightInject;
using LightInject.Mvc;
using LightInject.WebApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using BL;

namespace WebApplication1.App_Start
{
    public static class LightInjectConfig
    {
        public static void Configurate()
        {
            var container = new ServiceContainer();
            container.RegisterControllers(Assembly.GetExecutingAssembly());

            container.EnablePerWebRequestScope();

            var config = new MapperConfiguration(cfg => cfg.AddProfiles(
                  new List<Profile>() { new WebAutomapperProfile(), new BLAutomapperProfile() }));

            container.Register(c => config.CreateMapper());

            container = BLLightInjectConfiguration.Configuration(container);

            container.Register<IArticleService, ArticleService>();
            container.Register<IUserService, UserService>();
            container.Register<ICategoryService, CategoryService>();
            container.Register<ICommentService, CommentService>();


            container.EnableMvc();
        }
    }
}