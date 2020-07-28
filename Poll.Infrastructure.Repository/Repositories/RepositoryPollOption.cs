using Poll.Domain.Core.Interfaces.Repositories;
using Poll.Infrastructure.Data;

namespace Poll.Infrastructure.Repository.Repositories
{
    public class RepositoryPollOption : RepositoryBase<Poll.Domain.Models.PollOption>, IRepositoryPollOption
    {
        private readonly PollContext _context;
        public RepositoryPollOption(PollContext Context)
            : base(Context)
        {
            _context = Context;
        }
    }
}
