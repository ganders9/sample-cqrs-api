using Sample.CQRS.Core.Handlers;
using Sample.CQRS.Core.Infrastructure.Repositories;
using Sample.CQRS.Core.Models.Commands;

namespace Sample.CQRS.Application.Handlers
{
    public class RemoveStudentHandler : IRemoveStudentHandler
    {
        private readonly IRemoveStudentRepo _removeStudentRepo;

        public RemoveStudentHandler(IRemoveStudentRepo removeStudentRepo)
        {
            _removeStudentRepo = removeStudentRepo;
        }

        public void Handle(RemoveStudentCommand command)
        {
            _removeStudentRepo.Remove(command.Id);
        }
    }
}