using Sample.CQRS.Core.Common;

namespace Sample.CQRS.Core.Models.Commands
{
    public class RemoveStudentCommand : ICommand
    {
        public RemoveStudentCommand() { }

        public RemoveStudentCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}