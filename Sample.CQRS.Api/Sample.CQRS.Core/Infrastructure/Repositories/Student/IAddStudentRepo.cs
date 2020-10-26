using Sample.CQRS.Core.Models.Entities;

namespace Sample.CQRS.Core.Infrastructure.Repositories
{
    public interface IAddStudentRepo
    {
        void Add(Student student);
    }
}