using Microsoft.AspNetCore.Mvc;
using System.Linq;
using LibraryManagementSystem.Domain.StudentDetailModule;
using LibraryManagementSystem.Models.Main;
using RxWeb.Core.AspNetCore;
using RxWeb.Core.Security.Authorization;

namespace LibraryManagementSystem.Api.Controllers.StudentDetailModule
{
    [ApiController]
    [Route("api/[controller]")]
	
	public class StudentDetailsController : BaseDomainController<StudentDetail, StudentDetail>

    {
        public StudentDetailsController(IStudentDetailDomain domain):base(domain) {}

    }
}
