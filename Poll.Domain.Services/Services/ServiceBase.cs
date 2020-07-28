using Poll.Domain.Core.Interfaces.Repositories;
using Poll.Domain.Core.Interfaces.Services;
using System.Collections.Generic;
using System;

namespace Poll.Domain.Services.Services
{
    public abstract class ServiceBase<TEntity> : IDisposable, IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _repository;
        public ServiceBase(IRepositoryBase<TEntity> Repository)
        {
            _repository = Repository;
        }
        public virtual int Add(TEntity obj)
        {
            return _repository.Add(obj);
        }
        public virtual TEntity GetById(int id)
        {
            return _repository.GetById(id);
        }
        public virtual IEnumerable<TEntity> GetPollOptions(int id)
        {
            return _repository.GetPollOptions(id);
        }

        public virtual IEnumerable<TEntity> GetPollVotes(int poll_id)
        {
            return _repository.GetPollVotes(poll_id);
        }

        public virtual IEnumerable<TEntity> GetPollVotes(int poll_id, int option_id)
        {
            return _repository.GetPollVotes(poll_id, option_id);
        }
        public virtual IEnumerable<TEntity> GetPollStats(int poll_id)
        {
            return _repository.GetPollStats(poll_id);
        }
        public virtual void Update(TEntity obj)
        {
            _repository.Update(obj);
        }

        public virtual void Dispose()
        {
            _repository.Dispose();
        }
    }
}
