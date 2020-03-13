using Microsoft.AspNetCore.Mvc;
using System.Linq;
using LibraryManagementSystem.Domain.BookReturnModule;
using LibraryManagementSystem.Models.Main;
using RxWeb.Core.AspNetCore;
using RxWeb.Core.Security.Authorization;
using Microsoft.AspNetCore.Authorization;

namespace LibraryManagementSystem.Api.Controllers.BookReturnModule
{
    [ApiController]
    [Route("api/[controller]")]
	[AllowAnonymous]
	public class BookReturnsController : BaseDomainController<BookReturn, BookReturn>

    {
        public BookReturnsController(IBookReturnDomain domain):base(domain) {}

    }
}
