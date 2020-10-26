using Sample.CQRS.Core.Handlers;
using Sample.CQRS.Core.Infrastructure.Repositories;
using Sample.CQRS.Core.Models.Commands;
using Sample.CQRS.Core.Models.Entities;

namespace Sample.CQRS.Application.Handlers
{
    public class AddStudentHandler : IAddStudentHandler
    {
        private readonly IAddStudentRepo _addStudentRepo;

        public AddStudentHandler(IAddStudentRepo addStudentRepo)
        {
            _addStudentRepo = addStudentRepo;
        }

        public void Handle(AddStudentCommand command)
        {
            _addStudentRepo.Add(new Student
            {
                FirstName = command.FirstName,
                LastName = command.LastName,
                Email = command.Email,
                Grade = command.Grade
            });
        }
    }
}