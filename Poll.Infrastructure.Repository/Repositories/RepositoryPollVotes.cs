using Poll.Domain.Core.Interfaces.Repositories;
using Poll.Infrastructure.Data;

namespace Poll.Infrastructure.Repository.Repositories
{
    public class RepositoryPollVotes : RepositoryBase<Poll.Domain.Models.PollVotes>, IRepositoryPollVotes
    {
        private readonly PollContext _context;
        public RepositoryPollVotes(PollContext Context)
            : base(Context)
        {
            _context = Context;
        }
    }
}
