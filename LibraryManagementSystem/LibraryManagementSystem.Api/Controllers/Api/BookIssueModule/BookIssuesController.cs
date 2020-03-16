using Microsoft.AspNetCore.Mvc;
using System.Linq;
using LibraryManagementSystem.Domain.BookIssueModule;
using LibraryManagementSystem.Models.Main;
using RxWeb.Core.AspNetCore;
using RxWeb.Core.Security.Authorization;
using Microsoft.AspNetCore.Authorization;

namespace LibraryManagementSystem.Api.Controllers.BookIssueModule
{
    [ApiController]
    [Route("api/[controller]")]
	[AllowAnonymous]
	public class BookIssuesController : BaseDomainController<BookIssue, BookIssue>

    {
        public BookIssuesController(IBookIssueDomain domain):base(domain) {}

    }
}
