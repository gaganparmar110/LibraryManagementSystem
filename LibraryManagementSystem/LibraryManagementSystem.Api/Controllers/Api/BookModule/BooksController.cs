using Microsoft.AspNetCore.Mvc;
using System.Linq;
using LibraryManagementSystem.Domain.BookModule;
using LibraryManagementSystem.Models.Main;
using RxWeb.Core.AspNetCore;
using RxWeb.Core.Security.Authorization;

namespace LibraryManagementSystem.Api.Controllers.BookModule
{
    [ApiController]
    [Route("api/[controller]")]
	
	public class BooksController : BaseDomainController<vBook, vBook>

    {
        public BooksController(IBookDomain domain):base(domain) {}

    }
}
