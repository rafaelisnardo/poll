using Poll.Domain.Core.Interfaces.Repositories;
using Poll.Domain.Core.Interfaces.Services;

namespace Poll.Domain.Services.Services
{
    public class ServicePollOption : ServiceBase<Poll.Domain.Models.PollOption>, IServicePollOption
    {
        public readonly IRepositoryPollOption _repositoryPollOption;
        public ServicePollOption(IRepositoryPollOption repositoryPollOption)
            : base(repositoryPollOption)
        {
            _repositoryPollOption = repositoryPollOption;
        }
    }
}
