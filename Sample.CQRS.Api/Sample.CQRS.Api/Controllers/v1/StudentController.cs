using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Sample.CQRS.Core.Common;
using Sample.CQRS.Core.Models.Commands;
using Sample.CQRS.Core.Models.Entities;
using Sample.CQRS.Core.Models.Queries.Student;

namespace Sample.CQRS.Api.Controllers.v1
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("student")]
    public class StudentController : Controller
    {
        private readonly ICommandProcessor _commandProcessor;
        private readonly IQueryProcessor _queryProcessor;

        public StudentController(ICommandProcessor commandProcessor, IQueryProcessor queryProcessor)
        {
            _commandProcessor = commandProcessor;
            _queryProcessor = queryProcessor;
        }

        [HttpGet]
        public IEnumerable<Student> Get() => _queryProcessor.Process<IEnumerable<Student>, GetAllStudentsQuery>(new GetAllStudentsQuery());

        [HttpPut]
        public void UpdateStudent(UpdateStudentCommand command) => _commandProcessor.Process(command);

        [HttpPost]
        public void AddStudent(AddStudentCommand command) => _commandProcessor.Process(command);

        [HttpDelete]
        public void RemoveStudent(RemoveStudentCommand command) => _commandProcessor.Process(command);

    }
}
