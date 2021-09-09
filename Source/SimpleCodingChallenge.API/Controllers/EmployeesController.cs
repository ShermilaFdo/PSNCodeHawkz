using MediatR;
using Microsoft.AspNetCore.Mvc;
using SimpleCodingChallenge.Business.Actions.Employees;
using SimpleCodingChallenge.Common.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SimpleCodingChallenge.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class EmployeesController : Controller
    {
        private readonly IMediator mediator;

        public EmployeesController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        [Route("all")]
        public async Task<ActionResult<List<EmployeeDto>>> Index()
        {
            var result = await mediator.Send(new GetAllEmployeesCommand());
            return result.EmployeeList;
        }

        public async Task<ActionResult<EmployeeDto>> Create()
        {
            return null;
        }
    }
}
