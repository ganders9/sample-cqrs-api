using System.Collections.Generic;
using Sample.CQRS.Core.Models.Entities;

namespace Sample.CQRS.Core.Infrastructure.Repositories
{
    public interface IGetAllStudentRepo
    {
        IEnumerable<Student> GetAll();
    }
}