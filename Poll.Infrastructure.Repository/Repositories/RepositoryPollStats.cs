using Poll.Domain.Core.Interfaces.Repositories;
using Poll.Infrastructure.Data;

namespace Poll.Infrastructure.Repository.Repositories
{
    public class RepositoryPollStats : RepositoryBase<Poll.Domain.Models.PollStats>, IRepositoryPollStats
    {
        private readonly PollContext _context;
        public RepositoryPollStats(PollContext Context)
            : base(Context)
        {
            _context = Context;
        }
    }
}
