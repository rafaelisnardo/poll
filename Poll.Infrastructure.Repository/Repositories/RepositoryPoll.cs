using Poll.Domain.Core.Interfaces.Repositories;
using Poll.Infrastructure.Data;

namespace Poll.Infrastructure.Repository.Repositories
{
    public class RepositoryPoll : RepositoryBase<Poll.Domain.Models.Poll>, IRepositoryPoll
    {
        private readonly PollContext _context;
        public RepositoryPoll(PollContext Context)
            : base(Context)
        {
            _context = Context;
        }
    }
}