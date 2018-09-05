using Autofac;
using Autofac.Integration.Mvc;
using ShoppingCart.Business;
using ShoppingCart.Business.Interface;
using ShoppingCart.Data;
using ShoppingCart.Data.Interface;
using System.Reflection;
using System.Web.Mvc;

namespace ShoppingCart.UI.Settings
{
    public class Bootstrapper
    {
        public static void Run()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(Assembly.GetExecutingAssembly());

            //Data
            builder.RegisterType<CategoryData>().As<ICategoryData>().SingleInstance();
            builder.RegisterType<ProductData>().As<IProductData>().SingleInstance();
            builder.RegisterType<CampaignData>().As<ICampaignData>().SingleInstance();
            builder.RegisterType<CouponData>().As<ICouponData>().SingleInstance();

            //Business
            builder.RegisterType<CategoryBusiness>().As<ICategoryBusiness>().SingleInstance();
            builder.RegisterType<ProductBusiness>().As<IProductBusiness>().SingleInstance();
            builder.RegisterType<CartBusiness>().As<ICartBusiness>().SingleInstance();
            builder.RegisterType<CampaignBusiness>().As<ICampaignBusiness>().SingleInstance();
            builder.RegisterType<CouponBusiness>().As<ICouponBusiness>().SingleInstance();

            IContainer container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}