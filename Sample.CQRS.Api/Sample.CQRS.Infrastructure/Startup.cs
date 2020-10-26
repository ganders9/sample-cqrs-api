using Microsoft.Extensions.DependencyInjection;
using Sample.CQRS.Core.Infrastructure.Repositories;
using Sample.CQRS.Infrastructure.Repositories;

namespace Sample.CQRS.Infrastructure
{
    public class Startup
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            // Repositories
            services.AddScoped<IAddStudentRepo, AddStudentRepo>();
            services.AddScoped<IRemoveStudentRepo, RemoveStudentRepo>();
            services.AddScoped<IUpdateStudentRepo, UpdateStudentRepo>();
            services.AddScoped<IGetAllStudentRepo, GetAllStudentRepo>();
        }
    }
}