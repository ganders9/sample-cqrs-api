using System.Collections.Generic;
using Sample.CQRS.Core.Handlers;
using Sample.CQRS.Core.Infrastructure.Repositories;
using Sample.CQRS.Core.Models.Entities;
using Sample.CQRS.Core.Models.Queries.Student;

namespace Sample.CQRS.Application.Handlers
{
    public class GetAllStudentsHandler : IGetAllStudentsHandler
    {
        private readonly IGetAllStudentRepo _getAllStudentRepo;

        public GetAllStudentsHandler(IGetAllStudentRepo getAllStudentRepo)
        {
            _getAllStudentRepo = getAllStudentRepo;
        }

        public IEnumerable<Student> Handle(GetAllStudentsQuery query)
        {
            return _getAllStudentRepo.GetAll();
        }
    }
}