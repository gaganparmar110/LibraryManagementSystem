using Microsoft.Extensions.DependencyInjection;
using LibraryManagementSystem.Infrastructure.Singleton;
using LibraryManagementSystem.BoundedContext.Singleton;
using RxWeb.Core.Data;

namespace LibraryManagementSystem.Api.Bootstrap
{
    public static class Singleton
    {
        public static void AddSingletonService(this IServiceCollection serviceCollection)
        {
            #region Singleton
            serviceCollection.AddSingleton<ITenantDbConnectionInfo, TenantDbConnectionInfo>();
            serviceCollection.AddSingleton(typeof(UserAccessConfigInfo));
            #endregion Singleton
        }

    }
}




