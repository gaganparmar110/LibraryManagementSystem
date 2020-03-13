using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RxWeb.Core;
using LibraryManagementSystem.UnitOfWork.Main;
using LibraryManagementSystem.Models.Main;

namespace LibraryManagementSystem.Domain.StudentDetailModule
{
    public class StudentDetailDomain : IStudentDetailDomain
    {
        public StudentDetailDomain(IStudentDetailUow uow) {
            this.Uow = uow;
        }

        public async Task<object> GetAsync(StudentDetail parameters)
        {
            return await Uow.Repository<StudentDetail>().AllAsync();
           // throw new NotImplementedException();
        }

        public async Task<object> GetBy(StudentDetail parameters)
        {
            return await Uow.Repository<StudentDetail>().FindByAsync(t=>t.StudentId==parameters.StudentId);
           // throw new NotImplementedException();
        }
        

        public HashSet<string> AddValidation(StudentDetail entity)
        {
            return ValidationMessages;
        }

        public async Task AddAsync(StudentDetail entity)
        {
            await Uow.RegisterNewAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> UpdateValidation(StudentDetail entity)
        {
            return ValidationMessages;
        }

        public async Task UpdateAsync(StudentDetail entity)
        {
            await Uow.RegisterDirtyAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> DeleteValidation(StudentDetail parameters)
        {
            return ValidationMessages;
        }

        public Task DeleteAsync(StudentDetail parameters)
        {
            throw new NotImplementedException();
        }

        public IStudentDetailUow Uow { get; set; }

        private HashSet<string> ValidationMessages { get; set; } = new HashSet<string>();
    }

    public interface IStudentDetailDomain : ICoreDomain<StudentDetail, StudentDetail> { }
}
