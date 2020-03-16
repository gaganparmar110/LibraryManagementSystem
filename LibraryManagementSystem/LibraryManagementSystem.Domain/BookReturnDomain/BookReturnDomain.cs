using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RxWeb.Core;
using LibraryManagementSystem.UnitOfWork.Main;
using LibraryManagementSystem.Models.Main;
using RxWeb.Core.Data;
using LibraryManagementSystem.BoundedContext.SqlContext;
using Microsoft.Data.SqlClient;
using LibraryManagementSystem.Models.ViewModels;

namespace LibraryManagementSystem.Domain.BookReturnModule
{
    public class BookReturnDomain : IBookReturnDomain
    {
        public BookReturnDomain(IBookReturnUow uow, IDbContextManager<MainSqlDbContext> dbContextManager) {
            this.Uow = uow;
            DbContextManager = dbContextManager;
        }

        public async Task<object> GetAsync(BookReturn parameters)
        {
            vReturnBook vReturnBook = new vReturnBook();
            return await Uow.Repository<vReturnBook>().AllAsync();
            //throw new NotImplementedException();
        }

        public Task<object> GetBy(BookReturn parameters)
        {
            throw new NotImplementedException();
        }
        

        public HashSet<string> AddValidation(BookReturn entity)
        {
            return ValidationMessages;
        }

        public async Task AddAsync(BookReturn parameters)
        {
            var spParameters = new SqlParameter[1];
            spParameters[0] = new SqlParameter() { ParameterName = "BookIssueId", Value = parameters.BookIssueId };


            await DbContextManager.StoreProc<StoreProcResult>("[dbo].spReturnBook ", spParameters);
            try
            {
                await DbContextManager.CommitAsync();
            }
            catch (Exception e)
            {
                DbContextManager.RollbackTransaction();
            }
        }

        public HashSet<string> UpdateValidation(BookReturn entity)
        {
            return ValidationMessages;
        }

        public async Task UpdateAsync(BookReturn entity)
        {
            await Uow.RegisterDirtyAsync(entity);
            await Uow.CommitAsync();

        }

        public HashSet<string> DeleteValidation(BookReturn parameters)
        {
            return ValidationMessages;
        }

        public Task DeleteAsync(BookReturn parameters)
        {
            throw new NotImplementedException();
        }

        public IBookReturnUow Uow { get; set; }

        private HashSet<string> ValidationMessages { get; set; } = new HashSet<string>();
        private IDbContextManager<MainSqlDbContext> DbContextManager { get; set; }
    }

    public interface IBookReturnDomain : ICoreDomain<BookReturn, BookReturn> { }
}
