using Poll.Domain.Core.Interfaces.Repositories;
using Poll.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Poll.Infrastructure.Repository.Repositories
{
    public abstract class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        private readonly PollContext _context;

        public virtual void Dispose()
        {
            _context.Dispose();
        }

        public RepositoryBase(PollContext Context)
        {
            _context = Context;
        }

        #region CRUD
        public virtual int Add(TEntity obj)
        {
            try
            {
                int newId = 0;
                _context.Set<TEntity>().Add(obj);
                _context.SaveChanges();

                if (obj.GetType() == typeof(Poll.Domain.Models.Poll)) newId = (obj as Poll.Domain.Models.Poll).poll_id;
                if (obj.GetType() == typeof(Poll.Domain.Models.PollOption)) newId = (obj as Poll.Domain.Models.PollOption).option_id;

                return newId;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public virtual TEntity GetById(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }
        public virtual IEnumerable<TEntity> GetPollOptions(int id)
        {
            var poll_options = _context.PollOption.Where(p => p.poll_id == id);
            return (IEnumerable<TEntity>)poll_options;
        }

        public virtual IEnumerable<TEntity> GetPollVotes(int poll_id)
        {
            var poll_votes = _context.PollVotes.Where(p => p.poll_id == poll_id);
            return (IEnumerable<TEntity>)poll_votes;
        }

        public virtual IEnumerable<TEntity> GetPollVotes(int poll_id, int option_id)
        {
            var poll_votes = _context.PollVotes.Where(p => p.poll_id == poll_id && p.option_id == option_id);
            return (IEnumerable<TEntity>)poll_votes;
        }

        public virtual IEnumerable<TEntity> GetPollStats(int poll_id)
        {
            var poll_stats = _context.PollStats.Where(p => p.poll_id == poll_id);
            return (IEnumerable<TEntity>)poll_stats;
        }
        public virtual void Update(TEntity obj)
        {

            try
            {
                var local = _context.Set<TEntity>().Local.FirstOrDefault();
                if (local != null)
                {
                    _context.Entry(local).State = EntityState.Detached;
                }
                _context.Entry(obj).State = EntityState.Modified;
                _context.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public virtual void Remove(TEntity obj)
        {
            try
            {
                _context.Set<TEntity>().Remove(obj);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion
    }
}