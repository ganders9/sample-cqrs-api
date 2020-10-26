using Sample.CQRS.Core.Common;

namespace Sample.CQRS.Core.Models.Commands
{
    public class UpdateStudentCommand : ICommand
    {
        public UpdateStudentCommand() { }

        public UpdateStudentCommand(int id, string firstName, string lastName, string email, int grade)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Grade = grade;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Grade { get; set; }
    }
}