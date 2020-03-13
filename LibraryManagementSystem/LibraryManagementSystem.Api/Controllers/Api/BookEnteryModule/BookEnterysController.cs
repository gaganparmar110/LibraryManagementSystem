using Microsoft.AspNetCore.Mvc;
using System.Linq;
using LibraryManagementSystem.Domain.BookEnteryModule;
using LibraryManagementSystem.Models.Main;
using RxWeb.Core.AspNetCore;
using RxWeb.Core.Security.Authorization;

namespace LibraryManagementSystem.Api.Controllers.BookEnteryModule
{
    [ApiController]
    [Route("api/[controller]")]
	
	public class BookEnterysController : BaseDomainController<BookEntery, BookEntery>

    {
        public BookEnterysController(IBookEnteryDomain domain):base(domain) {}

    }
}
