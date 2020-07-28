using Poll.Application.DTO.DTO;
using Poll.Application.Interfaces;
using Poll.Domain.Core.Interfaces.Services;
using Poll.Infrastructure.CrossCutting.Adapter.Interfaces;
using System.Collections.Generic;


namespace Poll.Application.Service
{
    public class ApplicationServicePollVotes : IApplicationServicePollVotes
    {
        private readonly IServicePollVotes _servicePollVotes;
        private readonly IMapperPollVotes _mapperPollVotes;
        public ApplicationServicePollVotes(IServicePollVotes ServicePollVotes, IMapperPollVotes MapperPollVotes)

        {
            _servicePollVotes = ServicePollVotes;
            _mapperPollVotes = MapperPollVotes;
        }

        public int Add(PollVotesDTO obj)
        {
            var objPollVotes = _mapperPollVotes.MapperToEntity(obj);
            return _servicePollVotes.Add(objPollVotes);
        }

        public void Dispose()
        {
            _servicePollVotes.Dispose();
        }

        public IEnumerable<PollVotesDTO> GetPollVotes(int poll_id)
        {
            var objPollVotes = _servicePollVotes.GetPollVotes(poll_id);
            return _mapperPollVotes.MapperListPollVotes(objPollVotes);
        }

        public IEnumerable<PollVotesDTO> GetPollVotes(int poll_id, int option_id)
        {
            var objPollVotes = _servicePollVotes.GetPollVotes(poll_id, option_id);
            return _mapperPollVotes.MapperListPollVotes(objPollVotes);
        }

        public PollVotesDTO GetById(int id)
        {
            var objPollVotes = _servicePollVotes.GetById(id);
            return _mapperPollVotes.MapperToDTO(objPollVotes);
        }

        public void Update(PollVotesDTO obj)
        {
            var objPollVotes = _mapperPollVotes.MapperToEntity(obj);
            _servicePollVotes.Update(objPollVotes);
        }
    }
}
