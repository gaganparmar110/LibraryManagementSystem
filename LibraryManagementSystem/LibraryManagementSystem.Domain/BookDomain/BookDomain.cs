using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RxWeb.Core;
using LibraryManagementSystem.UnitOfWork.Main;
using LibraryManagementSystem.Models.Main;

namespace LibraryManagementSystem.Domain.BookModule
{
    public class BookDomain : IBookDomain
    {
        public BookDomain(IBookUow uow) {
            this.Uow = uow;
        }

        public async Task<object> GetAsync(vBook parameters)
        {
            return await Uow.Repository<vBook>().AllAsync();
            //throw new NotImplementedException();
        }

        public Task<object> GetBy(vBook parameters)
        {
            throw new NotImplementedException();
        }
        

        public HashSet<string> AddValidation(vBook entity)
        {
            return ValidationMessages;
        }

        public async Task AddAsync(vBook entity)
        {
            await Uow.RegisterNewAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> UpdateValidation(vBook entity)
        {
            return ValidationMessages;
        }

        public async Task UpdateAsync(vBook entity)
        {
            await Uow.RegisterDirtyAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> DeleteValidation(vBook parameters)
        {
            return ValidationMessages;
        }

        public Task DeleteAsync(vBook parameters)
        {
            throw new NotImplementedException();
        }

        public IBookUow Uow { get; set; }

        private HashSet<string> ValidationMessages { get; set; } = new HashSet<string>();
    }

    public interface IBookDomain : ICoreDomain<vBook, vBook> { }
}
