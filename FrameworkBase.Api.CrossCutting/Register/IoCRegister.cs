using FrameworkBase.Api.Application.Contracts.Services;
using FrameworkBase.Api.Application.Services;
using FrameworkBase.Api.DataAccess.Contracts.Repositories;
using FrameworkBase.Api.DataAccess.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace FrameworkBase.Api.CrossCutting.Register
{
    public static class IoCRegister
    {

        /// <summary>
        /// ------------THIS IS LIKE STARTUP ---------------//
        /// ---REGISTER THE CLASS AND AFTER I PASS TO THE OTHER CLASSES THAT ARE NEEDED----//
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        /// 

        public static IServiceCollection AddRegistration(this IServiceCollection services)
        {
            AddRegistrationService(services);
            AddRegistrationRepository(services);

            return services;
        }


        public static IServiceCollection AddRegistrationService(IServiceCollection services)
        {

            services.AddTransient<IAdminService, AdminService>();
            services.AddTransient<IUserService, UserService>();

            return services;
        }


        public static IServiceCollection AddRegistrationRepository(IServiceCollection services)
        {

            services.AddTransient<IAdminRepository, AdminRepository>();
            services.AddTransient<IBookingRepository, BookingRepository>();
            services.AddTransient<IOfficeRepository, OfficeRepoository>();
            services.AddTransient<IRoomRepository, RoomRepository>();
            services.AddTransient<IServiceRepository, ServiceRepository>();
            services.AddTransient<IUserRepository, UserRepository>();

            return services;
        }





    }
}
