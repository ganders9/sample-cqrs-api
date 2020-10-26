using Sample.CQRS.Core.Handlers;
using Sample.CQRS.Core.Infrastructure.Repositories;
using Sample.CQRS.Core.Models.Commands;
using Sample.CQRS.Core.Models.Entities;

namespace Sample.CQRS.Application.Handlers
{
    public class UpdateStudentHandler : IUpdateStudentHandler
    {
        private readonly IUpdateStudentRepo _updateStudentRepo;

        public UpdateStudentHandler(IUpdateStudentRepo updateStudentRepo)
        {
            _updateStudentRepo = updateStudentRepo;
        }

        public void Handle(UpdateStudentCommand command)
        {
            _updateStudentRepo.Update(new Student
            {
                Id = command.Id,
                FirstName = command.FirstName,
                LastName = command.LastName,
                Email = command.Email,
                Grade = command.Grade
            });
        }
    }
}