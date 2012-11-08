using Autofac;
using Autofac.Builder;
using CollectionJson.Controllers;
using CollectionJson.Infrastructure;
using CollectionJson.Models;
using CollectionJson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Http;
using WebApiContrib.IoC.Autofac;

namespace CollectionJson
{
    public static class ServiceConfiguration
    {
        public static void Configure(HttpConfiguration config)
        {
            config.Formatters.Add(new CollectionJsonFormatter());

            config.Routes.MapHttpRoute(
                "default", "{controller}/{id}",
                new { id = RouteParameter.Optional });

            var builder = new ContainerBuilder();
            builder.RegisterType<FakeFriendRepository>().As<IFriendRepository>();
            builder.RegisterType<CollectionJsonDocumentBuilder>().As<ICollectionJsonDocumentBuilder>();
            builder.RegisterApiControllers(typeof(ServiceConfiguration).Assembly);

            var container = builder.Build();
            var resolver = new WebApiContrib.IoC.Autofac.AutofacResolver(container);
           
            config.DependencyResolver = resolver;
        }

    }
}
