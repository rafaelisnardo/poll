using System.Collections.Generic;

namespace Poll.Domain.Core.Interfaces.Repositories
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        int Add(TEntity obj);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetPollOptions(int id);
        IEnumerable<TEntity> GetPollVotes(int poll_id);
        IEnumerable<TEntity> GetPollVotes(int poll_id, int option_id);
        IEnumerable<TEntity> GetPollStats(int poll_id);
        void Update(TEntity obj);
        void Dispose();
    }
}