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

namespace SimpleCodingChallenge.Business.Actions.Employees
{
    public class GetByIDEmployeesCommand : IRequest<GetByIDEmployeesCommandResponse>
    {
        public Guid ID { get; }

        public GetByIDEmployeesCommand(Guid ID)
        {
            this.ID = ID;
        }

    }

    public class GetByIDEmployeesCommandResponse
    {
        public EmployeeDto Employeedata { get; set; }
    }

    class GetByIDEmployeesCommandHandler : IRequestHandler<GetByIDEmployeesCommand, GetByIDEmployeesCommandResponse>
    {
        private readonly SimpleCodingChallengeDbContext dbContext;
        private readonly IMapper mapper;

        public GetByIDEmployeesCommandHandler(SimpleCodingChallengeDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        public async Task<GetByIDEmployeesCommandResponse> Handle(GetByIDEmployeesCommand request, CancellationToken cancellationToken)
        {
            var employee = await dbContext.Employees.FindAsync(request.ID);
            var data = mapper.Map<EmployeeDto>(employee);
            return new GetByIDEmployeesCommandResponse
            {
                Employeedata = data
            };

        }
    }
}
