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
    public class BookContext : BaseBoundedContext, IBookContext
    {
        public BookContext(MainSqlDbContext sqlDbContext,  IOptions<DatabaseConfig> databaseConfig, IHttpContextAccessor contextAccessor,ITenantDbConnectionInfo tenantDbConnection): base(sqlDbContext, databaseConfig.Value, contextAccessor,tenantDbConnection){ }

            #region DbSets
            		public DbSet<vBook> vBooks { get; set; }
            #endregion DbSets


    }


    public interface IBookContext : IDbContext
    {
    }
}

