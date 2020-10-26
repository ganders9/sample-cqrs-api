using System.Collections.Generic;
using Sample.CQRS.Core.Common;
using Sample.CQRS.Core.Models.Entities;
using Sample.CQRS.Core.Models.Queries.Student;

namespace Sample.CQRS.Core.Handlers
{
    public interface IGetAllStudentsHandler : IQueryHandler<IEnumerable<Student>, GetAllStudentsQuery>
    {
        
    }
}