using RxWeb.Core.Data;
using LibraryManagementSystem.BoundedContext.Main;

namespace LibraryManagementSystem.UnitOfWork.Main
{
    public class LoginUow : BaseUow, ILoginUow
    {
        public LoginUow(ILoginContext context, IRepositoryProvider repositoryProvider) : base(context, repositoryProvider) { }
    }

    public interface ILoginUow : ICoreUnitOfWork { }
}


