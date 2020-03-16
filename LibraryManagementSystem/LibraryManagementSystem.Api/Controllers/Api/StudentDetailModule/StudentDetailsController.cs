using Microsoft.AspNetCore.Mvc;
using System.Linq;
using LibraryManagementSystem.Domain.StudentDetailModule;
using LibraryManagementSystem.Models.Main;
using RxWeb.Core.AspNetCore;
using RxWeb.Core.Security.Authorization;
using Microsoft.AspNetCore.Authorization;

namespace LibraryManagementSystem.Api.Controllers.StudentDetailModule
{
    [ApiController]
    [Route("api/[controller]")]
    [AllowAnonymous]
    public class StudentDetailsController : BaseDomainController<StudentDetail, StudentDetail>

    {
        public StudentDetailsController(IStudentDetailDomain domain):base(domain) {}

    }
}
