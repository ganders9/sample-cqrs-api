using Sample.CQRS.Core.Common;

namespace Sample.CQRS.Core.Models.Commands
{
    public class AddStudentCommand : ICommand
    {
        public AddStudentCommand() { }

        public AddStudentCommand(string firstName, string lastName, string email, int grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Grade = grade;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Grade { get; set; }
    }
}