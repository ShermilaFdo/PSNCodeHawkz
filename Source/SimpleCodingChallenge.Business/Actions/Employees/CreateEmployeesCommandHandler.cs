using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SimpleCodingChallenge.Common.DTO;
using SimpleCodingChallenge.DataAccess.Database;
using System.Threading;
using Microsoft.Extensions.Logging;
using SimpleCodingChallenge.DataAccess.Entity;

namespace SimpleCodingChallenge.Business.Actions.Employees
{
    public class CreateEmployeeCommand : IRequest<int>
    {
        public string EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string BirthDate { get; set; }
        public string JobTitle { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; }
        public string Country { get; set; }
    }


    class CreateEmployeesCommandHandler : IRequestHandler<CreateEmployeeCommand, int>
    {
        private readonly SimpleCodingChallengeDbContext dbContext;
        private readonly IMapper mapper;
        private readonly ILogger<CreateEmployeesCommandHandler> logger;

        public CreateEmployeesCommandHandler(SimpleCodingChallengeDbContext dbContext, IMapper mapper,ILogger<CreateEmployeesCommandHandler> logger)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
            this.logger = logger;
        }

        public async Task<int> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var emp = new Employee();
            emp.EmployeeID = request.EmployeeID;
            emp.FirstName = request.FirstName;
            emp.LastName = request.LastName;
            emp.Address = request.Address;
            emp.Email = request.Email;
            emp.BirthDate = Convert.ToDateTime( request.BirthDate);
            emp.JobTitle = request.JobTitle;
            emp.Salary = request.Salary;
            emp.Department = request.Department;
            emp.Country = request.Country;

            dbContext.Employees.Add(emp);
            int flag = await dbContext.SaveChangesAsync();
            return flag;
        }
    }
}
