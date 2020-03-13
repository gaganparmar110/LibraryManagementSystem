using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RxWeb.Core;
using LibraryManagementSystem.UnitOfWork.Main;
using LibraryManagementSystem.Models.Main;
using RxWeb.Core.Security.Cryptography;

namespace LibraryManagementSystem.Domain.AdminModule
{

    public class AdminDetailDomain : IAdminDetailDomain
    {
        public AdminDetailDomain(IAdminUow uow,IPasswordHash passwordHash) {
            this.Uow = uow;
            PasswordHash = passwordHash;
        }

        public Task<object> GetAsync(AdminDetails parameters)
        {
            throw new NotImplementedException();
        }

        public Task<object> GetBy(AdminDetails parameters)
        {
            throw new NotImplementedException();
        }
        

        public HashSet<string> AddValidation(AdminDetails entity)
        {
            return ValidationMessages;
        }

        public async Task AddAsync(AdminDetails entity)
        {
            AdminDetails adminDetail = new AdminDetails();
           // PasswordResult passwordResult = PasswordHash.Encrypt(entity.Password);
            adminDetail.Name = entity.Name;
            adminDetail.UserName = entity.UserName;
          //  adminDetail.Password = passwordResult.Signature;
          //  adminDetail.Salt = passwordResult.Salt;
            await Uow.RegisterNewAsync(adminDetail);
            await Uow.CommitAsync();
        }

        public HashSet<string> UpdateValidation(AdminDetails entity)
        {
            return ValidationMessages;
        }

        public async Task UpdateAsync(AdminDetails entity)
        {
            

            await Uow.RegisterDirtyAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> DeleteValidation(AdminDetails parameters)
        {
            return ValidationMessages;
        }

        public Task DeleteAsync(AdminDetails parameters)
        {
            throw new NotImplementedException();
        }

        public IAdminUow Uow { get; set; }

        private HashSet<string> ValidationMessages { get; set; } = new HashSet<string>();
        private IPasswordHash PasswordHash { get; set; }
    }

    public interface IAdminDetailDomain : ICoreDomain<AdminDetails, AdminDetails> { }
}
