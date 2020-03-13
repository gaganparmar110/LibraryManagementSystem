using RxWeb.Core.Data;
using LibraryManagementSystem.BoundedContext.Main;

namespace LibraryManagementSystem.UnitOfWork.Main
{
    public class StudentDetailUow : BaseUow, IStudentDetailUow
    {
        public StudentDetailUow(IStudentDetailContext context, IRepositoryProvider repositoryProvider) : base(context, repositoryProvider) { }
    }

    public interface IStudentDetailUow : ICoreUnitOfWork { }
}


