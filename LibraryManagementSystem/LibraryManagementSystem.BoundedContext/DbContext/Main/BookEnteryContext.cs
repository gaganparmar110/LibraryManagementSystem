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
    public class BookEnteryContext : BaseBoundedContext, IBookEnteryContext
    {
        public BookEnteryContext(MainSqlDbContext sqlDbContext,  IOptions<DatabaseConfig> databaseConfig, IHttpContextAccessor contextAccessor,ITenantDbConnectionInfo tenantDbConnection): base(sqlDbContext, databaseConfig.Value, contextAccessor,tenantDbConnection){ }

            #region DbSets
            		public DbSet<BookEntery> BookEntery { get; set; }
		public DbSet<BookDetail> BookDetail { get; set; }
            		public DbSet<BookEntery> BookEnterys { get; set; }
		public DbSet<BookDetail> BookDetails { get; set; }
            #endregion DbSets



    }


    public interface IBookEnteryContext : IDbContext
    {
    }
}

