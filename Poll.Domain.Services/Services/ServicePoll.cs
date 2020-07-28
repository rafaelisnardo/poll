using Poll.Domain.Core.Interfaces.Repositories;
using Poll.Domain.Core.Interfaces.Services;

namespace Poll.Domain.Services.Services
{
    public class ServicePoll : ServiceBase<Poll.Domain.Models.Poll>, IServicePoll
    {
        public readonly IRepositoryPoll _repositoryPoll;
        public ServicePoll(IRepositoryPoll repositoryPoll)
            : base(repositoryPoll)
        {
            _repositoryPoll = repositoryPoll;
        }
    }
}
