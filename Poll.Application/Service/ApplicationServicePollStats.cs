using Poll.Application.DTO.DTO;
using Poll.Application.Interfaces;
using Poll.Domain.Core.Interfaces.Services;
using Poll.Infrastructure.CrossCutting.Adapter.Interfaces;
using System.Collections.Generic;


namespace Poll.Application.Service
{
    public class ApplicationServicePollStats : IApplicationServicePollStats
    {
        private readonly IServicePollStats _servicePollStats;
        private readonly IMapperPollStats _mapperPollStats;
        public ApplicationServicePollStats(IServicePollStats ServicePollStats, IMapperPollStats MapperPollStats)

        {
            _servicePollStats = ServicePollStats;
            _mapperPollStats = MapperPollStats;
        }

        public int Add(PollStatsDTO obj)
        {
            var objPollStats = _mapperPollStats.MapperToEntity(obj);
            return _servicePollStats.Add(objPollStats);
        }

        public void Dispose()
        {
            _servicePollStats.Dispose();
        }

        public IEnumerable<PollStatsDTO> GetPollStats(int poll_id)
        {
            var objPollStats = _servicePollStats.GetPollStats(poll_id);
            return _mapperPollStats.MapperListPollStats(objPollStats);
        }

        public PollStatsDTO GetById(int id)
        {
            var objPollStats = _servicePollStats.GetById(id);
            return _mapperPollStats.MapperToDTO(objPollStats);
        }

        public void Update(PollStatsDTO obj)
        {
            var objPollStats = _mapperPollStats.MapperToEntity(obj);
            _servicePollStats.Update(objPollStats);
        }
    }
}
