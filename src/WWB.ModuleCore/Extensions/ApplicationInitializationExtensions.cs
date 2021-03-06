using WWB.ModuleCore.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace WWB.ModuleCore.Extensions
{
    public static class ApplicationInitializationExtensions
    {
        public static IApplicationBuilder GetApplicationBuilder(this ApplicationInitializationContext applicationInitializationContext)
        {
            return applicationInitializationContext.ServiceProvider.GetRequiredService<IObjectAccessor<IApplicationBuilder>>().Value;
        }


    }
}
