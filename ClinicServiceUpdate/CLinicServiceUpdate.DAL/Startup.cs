using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ClinicServiceUpdate.DAL.Handlers;
using ClinicServiceUpdate.DAL.Abstractions;
using ClinicServiceUpdate.DAL.Implementations;


namespace ClinicServiceUpdate.DAL
{
	class Startup
	{
		public IConfiguration Configuration { get; }
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public void ConfigureServices(IServiceCollection services)
		{
			services.AddSingleton<Db>();

			services.AddSingleton<IDepartmentRepository, DepartmentRepository>();
			services.AddSingleton<IPositionRepository, PositionRepository>();
			services.AddSingleton<IRequestRepository, RequestRepository>();
			services.AddSingleton<IRoleRepository, RoleRepository>();
			services.AddSingleton<IScheduleRepository, ScheduleRepository>();
			services.AddSingleton<ISessionRepository, SessionRepository>();
			services.AddSingleton<ITypeOfRequestRepository, TypeOfRequestRepository>();
			services.AddSingleton<IUserRepository, UserRepository>();
		}
	}
}
