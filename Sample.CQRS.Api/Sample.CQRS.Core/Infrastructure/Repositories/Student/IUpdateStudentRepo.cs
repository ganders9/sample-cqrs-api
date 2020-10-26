using Sample.CQRS.Core.Models.Entities;

namespace Sample.CQRS.Core.Infrastructure.Repositories
{
    public interface IUpdateStudentRepo
    {
        void Update(Student student);
    }
}