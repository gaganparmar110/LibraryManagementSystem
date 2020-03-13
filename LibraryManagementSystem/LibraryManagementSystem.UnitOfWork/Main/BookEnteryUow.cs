using RxWeb.Core.Data;
using LibraryManagementSystem.BoundedContext.Main;

namespace LibraryManagementSystem.UnitOfWork.Main
{
    public class BookEnteryUow : BaseUow, IBookEnteryUow
    {
        public BookEnteryUow(IBookEnteryContext context, IRepositoryProvider repositoryProvider) : base(context, repositoryProvider) { }
    }

    public interface IBookEnteryUow : ICoreUnitOfWork { }
}


