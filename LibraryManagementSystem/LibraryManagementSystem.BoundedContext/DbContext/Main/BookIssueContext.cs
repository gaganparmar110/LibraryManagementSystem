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
    public class BookIssueContext : BaseBoundedContext, IBookIssueContext
    {
        public BookIssueContext(MainSqlDbContext sqlDbContext,  IOptions<DatabaseConfig> databaseConfig, IHttpContextAccessor contextAccessor,ITenantDbConnectionInfo tenantDbConnection): base(sqlDbContext, databaseConfig.Value, contextAccessor,tenantDbConnection){ }

            #region DbSets
            		public DbSet<vBookIssue> vBookIssue { get; set; }
		public DbSet<BookIssue> BookIssue { get; set; }
		public DbSet<BookReturn> BookReturn { get; set; }
            #endregion DbSets


    }


    public interface IBookIssueContext : IDbContext
    {
    }
}

