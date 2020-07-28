using Autofac;
using Poll.Application.Interfaces;
using Poll.Application.Service;
using Poll.Domain.Core.Interfaces.Repositories;
using Poll.Domain.Core.Interfaces.Services;
using Poll.Domain.Services.Services;
using Poll.Infrastructure.CrossCutting.Adapter.Interfaces;
using Poll.Infrastructure.CrossCutting.Adapter.Map;
using Poll.Infrastructure.Repository.Repositories;

namespace Poll.Infrastructure.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region IOC Application
            builder.RegisterType<ApplicationServicePoll>().As<IApplicationServicePoll>();
            builder.RegisterType<ApplicationServicePollOption>().As<IApplicationServicePollOption>();
            builder.RegisterType<ApplicationServicePollVotes>().As<IApplicationServicePollVotes>();
            builder.RegisterType<ApplicationServicePollStats>().As<IApplicationServicePollStats>();
            #endregion

            #region IOC Services
            builder.RegisterType<ServicePoll>().As<IServicePoll>();
            builder.RegisterType<ServicePollOption>().As<IServicePollOption>();
            builder.RegisterType<ServicePollVotes>().As<IServicePollVotes>();
            builder.RegisterType<ServicePollStats>().As<IServicePollStats>();
            #endregion

            #region IOC Repositories SQL
            builder.RegisterType<RepositoryPoll>().As<IRepositoryPoll>();
            builder.RegisterType<RepositoryPollOption>().As<IRepositoryPollOption>();
            builder.RegisterType<RepositoryPollVotes>().As<IRepositoryPollVotes>();
            builder.RegisterType<RepositoryPollStats>().As<IRepositoryPollStats>();
            #endregion

            #region IOC Mapper
            builder.RegisterType<MapperPoll>().As<IMapperPoll>();
            builder.RegisterType<MapperPollOption>().As<IMapperPollOption>();
            builder.RegisterType<MapperPollVotes>().As<IMapperPollVotes>();
            builder.RegisterType<MapperPollStats>().As<IMapperPollStats>();
            #endregion
        }
    }
}