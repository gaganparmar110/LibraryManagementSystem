using Microsoft.AspNetCore.Mvc;
using System.Linq;
using LibraryManagementSystem.Domain.FineCalculateModule;
using LibraryManagementSystem.Models.Main;
using RxWeb.Core.AspNetCore;
using RxWeb.Core.Security.Authorization;
using Microsoft.AspNetCore.Authorization;

namespace LibraryManagementSystem.Api.Controllers.FineCalculateModule
{
    [ApiController]
    [Route("api/[controller]")]
    [AllowAnonymous]
    public class FineCalculateController : BaseDomainController<BookIssue, BookIssue>

    {
        public FineCalculateController(IFineCalculateDomain domain):base(domain) {}

    }
}
