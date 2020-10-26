using Microsoft.Extensions.DependencyInjection;
using Sample.CQRS.Application.Common;
using Sample.CQRS.Application.Handlers;
using Sample.CQRS.Core.Common;
using Sample.CQRS.Core.Handlers;

namespace Sample.CQRS.Application
{
    public class Startup
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            // Processors
            services.AddScoped<ICommandProcessor, CommandProcessor>();
            services.AddScoped<IQueryProcessor, QueryProcessor>();

            // CommandHandlers
            services.AddScoped<IAddStudentHandler, AddStudentHandler>();
            services.AddScoped<IUpdateStudentHandler, UpdateStudentHandler>();
            services.AddScoped<IRemoveStudentHandler, RemoveStudentHandler>();
            services.AddScoped<IGetAllStudentsHandler, GetAllStudentsHandler>();
        }
    }
}