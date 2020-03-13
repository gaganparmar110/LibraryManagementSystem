using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using LibraryManagementSystem.BoundedContext.SqlContext;
using LibraryManagementSystem.Models.Main;
using LibraryManagementSystem.Models;
using LibraryManagementSystem.BoundedContext.Singleton;
using RxWeb.Core.Data;
using RxWeb.Core.Data.Models;
using RxWeb.Core.Data.BoundedContext;

namespace LibraryManagementSystem.BoundedContext.Main
{
    public class BookReturnContext : BaseBoundedContext, IBookReturnContext
    {
        public BookReturnContext(MainSqlDbContext sqlDbContext,  IOptions<DatabaseConfig> databaseConfig, IHttpContextAccessor contextAccessor,ITenantDbConnectionInfo tenantDbConnection): base(sqlDbContext, databaseConfig.Value, contextAccessor,tenantDbConnection){ }

            #region DbSets
        public DbSet<vReturnBook> vReturnBooks { get; set; }
        public DbSet<BookReturn>BookReturns { get; set; }
            #endregion DbSets

    }


    public interface IBookReturnContext : IDbContext
    {
    }
}

