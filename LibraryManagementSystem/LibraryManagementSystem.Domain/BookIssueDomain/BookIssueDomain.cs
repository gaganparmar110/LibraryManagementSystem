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

namespace LibraryManagementSystem.Domain.BookIssueModule
{
    public class BookIssueDomain : IBookIssueDomain
    {
        public BookIssueDomain(IBookIssueUow uow, IDbContextManager<MainSqlDbContext> dbContextManager) {
            this.Uow = uow;
            DbContextManager = dbContextManager;
        }

        public async Task<object> GetAsync(BookIssue parameters)
        {
            //vBookIssue vBookIssue = new vBookIssue();
            return await Uow.Repository<vBookIssue>().AllAsync();
            //throw new NotImplementedException();
        }

        public Task<object> GetBy(BookIssue parameters)
        {
            throw new NotImplementedException();
        }
        

        public HashSet<string> AddValidation(BookIssue entity)
        {
            return ValidationMessages;
        }

        public async Task AddAsync(BookIssue parameters)
        {
            var spParameters = new SqlParameter[4];
            spParameters[0] = new SqlParameter() { ParameterName = "StudentId", Value = parameters.StudentId };
            spParameters[1] = new SqlParameter() { ParameterName = "BookDetailId", Value = parameters.BookDetailId };
            spParameters[2] = new SqlParameter() { ParameterName = "IssueDate", Value = parameters.IssueDate };
            spParameters[3] = new SqlParameter() { ParameterName = "ReturnDate", Value = parameters.ReturnDate };
           

            await DbContextManager.StoreProc<StoreProcResult>("[dbo].spIssueBook ", spParameters);
            try
            {
                await DbContextManager.CommitAsync();
            }
            catch (Exception e)
            {
                DbContextManager.RollbackTransaction();
            }
        }

        public HashSet<string> UpdateValidation(BookIssue entity)
        {
            return ValidationMessages;
        }

        public async Task UpdateAsync(BookIssue entity)
        {
            await Uow.RegisterDirtyAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> DeleteValidation(BookIssue parameters)
        {
            return ValidationMessages;
        }

        public Task DeleteAsync(BookIssue parameters)
        {
            throw new NotImplementedException();
        }

        public IBookIssueUow Uow { get; set; }

        private HashSet<string> ValidationMessages { get; set; } = new HashSet<string>();
        private IDbContextManager<MainSqlDbContext> DbContextManager { get; set; }
    }

    public interface IBookIssueDomain : ICoreDomain<BookIssue, BookIssue> { }
}
