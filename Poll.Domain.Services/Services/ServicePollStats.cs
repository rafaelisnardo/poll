using Poll.Domain.Core.Interfaces.Repositories;
using Poll.Domain.Core.Interfaces.Services;

namespace Poll.Domain.Services.Services
{
    public class ServicePollStats : ServiceBase<Poll.Domain.Models.PollStats>, IServicePollStats
    {
        public readonly IRepositoryPollStats _repositoryPollStats;
        public ServicePollStats(IRepositoryPollStats repositoryPollStats)
            : base(repositoryPollStats)
        {
            _repositoryPollStats = repositoryPollStats;
        }
    }
}
