#region Namespace
using Microsoft.Extensions.DependencyInjection;
using LibraryManagementSystem.Infrastructure.Security;
using RxWeb.Core.Data;
using RxWeb.Core.Security;
using RxWeb.Core.Annotations;
using RxWeb.Core;
using LibraryManagementSystem.UnitOfWork.DbEntityAudit;
using LibraryManagementSystem.BoundedContext.Main;
using LibraryManagementSystem.UnitOfWork.Main;
using LibraryManagementSystem.Domain.AdminModule;
            using LibraryManagementSystem.Domain.StudentDetailModule;
            using LibraryManagementSystem.Domain.BookEnteryModule;
            using LibraryManagementSystem.Domain.BookModule;
            using LibraryManagementSystem.Domain.BookIssueModule;
            using LibraryManagementSystem.Domain.BookReturnModule;
            using LibraryManagementSystem.Domain.FineCalculateModule;
            #endregion Namespace










namespace LibraryManagementSystem.Api.Bootstrap
{
    public static class ScopedExtension
    {

        public static void AddScopedService(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IRepositoryProvider, RepositoryProvider>();
            serviceCollection.AddScoped<ITokenAuthorizer, TokenAuthorizer>();
            serviceCollection.AddScoped<IModelValidation, ModelValidation>();
            serviceCollection.AddScoped<IAuditLog, AuditLog>();
            serviceCollection.AddScoped<IApplicationTokenProvider, ApplicationTokenProvider>();
            serviceCollection.AddScoped(typeof(IDbContextManager<>), typeof(DbContextManager<>));

            #region ContextService

            serviceCollection.AddScoped<ILoginContext, LoginContext>();
            serviceCollection.AddScoped<ILoginUow, LoginUow>();
                        serviceCollection.AddScoped<IAdminContext, AdminContext>();
            serviceCollection.AddScoped<IAdminUow, AdminUow>();
                        serviceCollection.AddScoped<IStudentDetailContext, StudentDetailContext>();
            serviceCollection.AddScoped<IStudentDetailUow, StudentDetailUow>();
                       
                        serviceCollection.AddScoped<IBookEnteryContext, BookEnteryContext>();
            serviceCollection.AddScoped<IBookEnteryUow, BookEnteryUow>();
                        serviceCollection.AddScoped<IBookContext, BookContext>();
            serviceCollection.AddScoped<IBookUow, BookUow>();
                        serviceCollection.AddScoped<IBookIssueContext, BookIssueContext>();
            serviceCollection.AddScoped<IBookIssueUow, BookIssueUow>();
                        serviceCollection.AddScoped<IBookReturnContext, BookReturnContext>();
            serviceCollection.AddScoped<IBookReturnUow, BookReturnUow>();
                        serviceCollection.AddScoped<IBookReturnContext, BookReturnContext>();
            serviceCollection.AddScoped<IBookReturnUow, BookReturnUow>();
            #endregion ContextService











            #region DomainService

            
            serviceCollection.AddScoped<IAdminDetailDomain, AdminDetailDomain>();
            
            serviceCollection.AddScoped<IAdminDetailDomain, AdminDetailDomain>();
            
            serviceCollection.AddScoped<IStudentDetailDomain, StudentDetailDomain>();
            
            serviceCollection.AddScoped<IBookEnteryDomain, BookEnteryDomain>();
            
            serviceCollection.AddScoped<IBookDomain, BookDomain>();
            
            serviceCollection.AddScoped<IBookIssueDomain, BookIssueDomain>();
            
            serviceCollection.AddScoped<IBookReturnDomain, BookReturnDomain>();
            
            
            
            serviceCollection.AddScoped<IFineCalculateDomain, FineCalculateDomain>();
            #endregion DomainService









        }
    }
}




