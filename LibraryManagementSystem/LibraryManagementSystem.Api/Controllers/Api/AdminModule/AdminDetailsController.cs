using Microsoft.AspNetCore.Mvc;
using System.Linq;
using LibraryManagementSystem.Domain.AdminModule;
using LibraryManagementSystem.Models.Main;
using RxWeb.Core.AspNetCore;
using RxWeb.Core.Security.Authorization;

namespace LibraryManagementSystem.Api.Controllers.AdminModule
{
    [ApiController]
    [Route("api/[controller]")]
	
	public class AdminDetailsController : BaseDomainController<AdminDetails, AdminDetails>

    {
        public AdminDetailsController(IAdminDetailDomain domain):base(domain) {}

    }
}
