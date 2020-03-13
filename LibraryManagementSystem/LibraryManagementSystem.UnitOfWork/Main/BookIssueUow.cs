using RxWeb.Core.Data;
using LibraryManagementSystem.BoundedContext.Main;

namespace LibraryManagementSystem.UnitOfWork.Main
{
    public class BookIssueUow : BaseUow, IBookIssueUow
    {
        public BookIssueUow(IBookIssueContext context, IRepositoryProvider repositoryProvider) : base(context, repositoryProvider) { }
    }

    public interface IBookIssueUow : ICoreUnitOfWork { }
}


