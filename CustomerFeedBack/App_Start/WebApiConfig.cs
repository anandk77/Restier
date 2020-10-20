using System.Linq;
using System.Web.Http;
using System.Web.OData.Extensions;
using CustomerFeedBack.Models;
using Microsoft.Restier.Core.Submit;
using Microsoft.Restier.Providers.EntityFramework;
using Microsoft.Restier.Publishers.OData;
using Microsoft.Restier.Publishers.OData.Batch;

namespace CustomerFeedBack
{
    public static class WebApiConfig
    {
        public async static void Register(HttpConfiguration config)
        {
            config.Filter().Expand().Select().OrderBy().MaxTop(null).Count();
            await config.MapRestierRoute<EntityFrameworkApi<CustomerRnR>>(
                "CustomerRnR",
                "api/CustomerRnR",
                new RestierBatchHandler(GlobalConfiguration.DefaultServer));

            //Currently we dont have custom class to implement Authorization and Error Handling
            //config.Filters.Add(new AuthorizeAttribute());

            //Show error code
            config.SetUseVerboseErrors(false);

        }
    }
}
