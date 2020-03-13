using RxWeb.Core.Data;
using LibraryManagementSystem.BoundedContext.Main;

namespace LibraryManagementSystem.UnitOfWork.Main
{
    public class BookUow : BaseUow, IBookUow
    {
        public BookUow(IBookContext context, IRepositoryProvider repositoryProvider) : base(context, repositoryProvider) { }
    }

    public interface IBookUow : ICoreUnitOfWork { }
}


