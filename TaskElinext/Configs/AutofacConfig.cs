using Autofac;
using Autofac.Integration.Mvc;
using Services.Interfaces;
using Services.Services;
using System.Web.Mvc;

namespace TaskElinext.Configs
{
    public static class AutofacConfig
    {
        public static void ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            builder.RegisterType<CommentService>().As<ICommentService>();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}