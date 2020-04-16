using Autofac;
using Autofac.Integration.WebApi;
using BL.Service;
using System.Reflection;
using System.Web.Http;

namespace Web_Api.App_Start

{
    public static class AutofacConfig
    {
        public static void InitAutfac()
        {
            var builder = new ContainerBuilder();

            // Get your HttpConfiguration.
            var config = GlobalConfiguration.Configuration;

            // Register your Web API controllers.
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            // OPTIONAL: Register the Autofac filter provider.
            builder.RegisterWebApiFilterProvider(config);

            // OPTIONAL: Register the Autofac model binder provider.
            builder.RegisterWebApiModelBinderProvider();


            builder.RegisterType<ArticleService>().As<IArticleService>();
            builder.RegisterType<UserService>().As<IUserService>();
            builder.RegisterType<CommentService>().As<ICommentService>();
            builder.RegisterType<CategoryService>().As<ICategoryService>();

            // Set the dependency resolver to be Autofac.
            var container = builder.Build();
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);

        }
    }
}