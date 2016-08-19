
using Microsoft.OData.Edm;
using System.Web.Http;
using System.Web.OData.Batch;
using System.Web.OData.Builder;
using System.Web.OData.Extensions;

namespace Learn_Owin.App_Start
{
    public partial class Startup
    {
        public static class ODataApi
        {

            public static HttpConfiguration Configure(HttpConfiguration config)
            {   
                
                config.MapODataServiceRoute("odata", "api/odata", GetEdmModel(), new DefaultODataBatchHandler(GlobalConfiguration.DefaultServer));
                config.EnsureInitialized();

                return config;
            }
            private static IEdmModel GetEdmModel()
            {
                ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
                //builder.EntitySet<Product>("Products");
                //builder.EntitySet<Employee>("Employees"); // Navigational entity..
                //builder.Namespace = "test";

                //var productEntityType1 = builder.EntityType<Product>();
                //var funcGetMyProductPrice1 = productEntityType1.Collection.Function("GetMyProductPrice").Returns<decimal>();

                //var productEntityType = builder.EntityType<Product>();
                //var funcGetMyProductPriceWithId = productEntityType.Collection.Function("GetMyProductPriceWithId").Returns<decimal>();
                //funcGetMyProductPriceWithId.Parameter<int>("Id");


                //var funcGetMyProductPrice = builder.Function("GetUnboundProductPriceWithId").Returns<decimal>();
                //funcGetMyProductPrice.Parameter<int>("Id");


                //var actionBoundAction = builder.EntityType<Product>().Action("BoundAction").Returns<string>();
                
                var edmModel = builder.GetEdmModel();
                return edmModel;
            }
        }
    }
}