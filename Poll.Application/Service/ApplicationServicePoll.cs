using Poll.Application.DTO.DTO;
using Poll.Application.Interfaces;
using Poll.Domain.Core.Interfaces.Services;
using Poll.Infrastructure.CrossCutting.Adapter.Interfaces;

namespace Poll.Application.Service
{
    public class ApplicationServicePoll : IApplicationServicePoll
    {
        private readonly IServicePoll _servicePoll;
        private readonly IMapperPoll _mapperPoll;
        public ApplicationServicePoll(IServicePoll ServicePoll, IMapperPoll MapperPoll)
                                              
        {
            _servicePoll = ServicePoll;
            _mapperPoll = MapperPoll;
        }

        public int Add(NewPollDTO obj)
        {
            var objPoll = _mapperPoll.MapperToEntity(obj.poll_description);
            return _servicePoll.Add(objPoll);
        }

        public void Dispose()
        {
            _servicePoll.Dispose();
        }

        public PollDTO GetById(int id)
        {
            var objPoll = _servicePoll.GetById(id);
            return _mapperPoll.MapperToDTO(objPoll);
        }
    }
}
