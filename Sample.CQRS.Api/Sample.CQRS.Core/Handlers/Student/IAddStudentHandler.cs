using Sample.CQRS.Core.Common;
using Sample.CQRS.Core.Models.Commands;

namespace Sample.CQRS.Core.Handlers
{
    public interface IAddStudentHandler : ICommandHandler<AddStudentCommand>
    {
        
    }
}