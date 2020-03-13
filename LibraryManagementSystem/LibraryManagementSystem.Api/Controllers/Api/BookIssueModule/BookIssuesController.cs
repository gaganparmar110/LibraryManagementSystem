using Microsoft.AspNetCore.Mvc;
using System.Linq;
using LibraryManagementSystem.Domain.BookIssueModule;
using LibraryManagementSystem.Models.Main;
using RxWeb.Core.AspNetCore;
using RxWeb.Core.Security.Authorization;

namespace LibraryManagementSystem.Api.Controllers.BookIssueModule
{
    [ApiController]
    [Route("api/[controller]")]
	
	public class BookIssuesController : BaseDomainController<BookIssue, vBookIssue>

    {
        public BookIssuesController(IBookIssueDomain domain):base(domain) {}

    }
}
