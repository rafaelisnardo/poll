using Poll.Domain.Core.Interfaces.Repositories;
using Poll.Domain.Core.Interfaces.Services;

namespace Poll.Domain.Services.Services
{
    public class ServicePollVotes : ServiceBase<Poll.Domain.Models.PollVotes>, IServicePollVotes
    {
        public readonly IRepositoryPollVotes _repositoryPollVotes;
        public ServicePollVotes(IRepositoryPollVotes repositoryPollVotes)
            : base(repositoryPollVotes)
        {
            _repositoryPollVotes = repositoryPollVotes;
        }
    }
}
