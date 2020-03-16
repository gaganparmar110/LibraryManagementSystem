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

namespace LibraryManagementSystem.Domain.BookEnteryModule
{
    public class BookEnteryDomain : IBookEnteryDomain
    {
        public BookEnteryDomain(IBookEnteryUow uow, IDbContextManager<MainSqlDbContext> dbContextManager) {
            this.Uow = uow;
            DbContextManager = dbContextManager;
        }

        public Task<object> GetAsync(BookEntery parameters)
        {
            throw new NotImplementedException();
        }

        public Task<object> GetBy(BookEntery parameters)
        {
            throw new NotImplementedException();
        }
        

        public HashSet<string> AddValidation(BookEntery entity)
        {
            return ValidationMessages;
        }

        public async Task AddAsync(BookEntery parameters)
        {
           
            var spParameters = new SqlParameter[4];
            spParameters[0] = new SqlParameter() { ParameterName = "BookTitle", Value = parameters.BookTitle };
            spParameters[1] = new SqlParameter() { ParameterName = "BookName", Value = parameters.BookName };
            spParameters[2] = new SqlParameter() { ParameterName = "Copies", Value = parameters.Copies };
          
            spParameters[3] = new SqlParameter() { ParameterName = "AuthorName", Value = parameters.AuthorName };
           
            await DbContextManager.StoreProc<StoreProcResult>("[dbo].spBookEntery ", spParameters);
            try
            {
                await DbContextManager.CommitAsync();
            }
            catch (Exception e)
            {
                DbContextManager.RollbackTransaction();
            }
        }

        public HashSet<string> UpdateValidation(BookEntery entity)
        {
            return ValidationMessages;
        }

        public async Task UpdateAsync(BookEntery entity)
        {
            await Uow.RegisterDirtyAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> DeleteValidation(BookEntery parameters)
        {
            return ValidationMessages;
        }

        public async Task DeleteAsync(BookEntery parameters)
        {
            BookDetail bookDetail = new BookDetail();
            var candidate = Uow.Repository<BookEntery>().FindByKey(parameters.BookEnteryId);
            await Uow.RegisterDeletedAsync(candidate);
            await Uow.CommitAsync();
            //throw new NotImplementedException();
        }

        public IBookEnteryUow Uow { get; set; }

        private HashSet<string> ValidationMessages { get; set; } = new HashSet<string>();
        private IDbContextManager<MainSqlDbContext> DbContextManager { get; set; }
    }

    public interface IBookEnteryDomain : ICoreDomain<BookEntery, BookEntery> { }
}
