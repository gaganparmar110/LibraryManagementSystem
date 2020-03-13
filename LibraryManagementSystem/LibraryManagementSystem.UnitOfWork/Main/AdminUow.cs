using RxWeb.Core.Data;
using LibraryManagementSystem.BoundedContext.Main;

namespace LibraryManagementSystem.UnitOfWork.Main
{
    public class AdminUow : BaseUow, IAdminUow
    {
        public AdminUow(IAdminContext context, IRepositoryProvider repositoryProvider) : base(context, repositoryProvider) { }
    }

    public interface IAdminUow : ICoreUnitOfWork { }
}


