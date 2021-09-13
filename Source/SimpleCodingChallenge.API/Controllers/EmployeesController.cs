using MediatR;
using Microsoft.AspNetCore.Mvc;
using SimpleCodingChallenge.Business.Actions.Employees;
using SimpleCodingChallenge.Common.DTO;
using System;
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

        [HttpPut]
        [Route("")]
        public async Task<ActionResult> Create([FromBody] CreateEmployeeCommand command)
        {
            return Ok(await mediator.Send(command));
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<EmployeeDto>> GetByID(Guid ID)
        {
            var result = await mediator.Send(new GetByIDEmployeesCommand(ID));
            //return result.Employeedata;
            return result != null ? (ActionResult)Ok(result.Employeedata) : NotFound();

            //if (result.Employeedata == null)
            //{
            //    Response.StatusCode = 404;
            //    return View("Epmloyee not Found");
            //}
            //else
            //{
            //    return result.Employeedata;
            //}


        }


    }
}
