using System.Collections.Generic;
using Sample.CQRS.Core.Infrastructure.Repositories;
using Sample.CQRS.Core.Models.Entities;

namespace Sample.CQRS.Infrastructure.Repositories
{
    public class GetAllStudentRepo : IGetAllStudentRepo
    {
        public IEnumerable<Student> GetAll()
        {
            var result = new List<Student>
            {
                new Student
                {
                    Id = 1,
                    FirstName = "Gustaf",
                    LastName = "Andersson",
                    Email = "gustaf@andersson.se",
                    Grade = 3
                }
            };
            return result;
        }
    }
}