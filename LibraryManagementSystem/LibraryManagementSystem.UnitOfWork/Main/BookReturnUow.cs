using RxWeb.Core.Data;
using LibraryManagementSystem.BoundedContext.Main;

namespace LibraryManagementSystem.UnitOfWork.Main
{
    public class BookReturnUow : BaseUow, IBookReturnUow
    {
        public BookReturnUow(IBookReturnContext context, IRepositoryProvider repositoryProvider) : base(context, repositoryProvider) { }
    }

    public interface IBookReturnUow : ICoreUnitOfWork { }
}


