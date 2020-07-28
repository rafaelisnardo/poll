using Poll.Application.DTO.DTO;
using System.Collections.Generic;

namespace Poll.Infrastructure.CrossCutting.Adapter.Interfaces
{
    public interface IMapperPollStats
    {
        Poll.Domain.Models.PollStats MapperToEntity(PollStatsDTO PollStatsDTO);
        IEnumerable<PollStatsDTO> MapperListPollStats(IEnumerable<Poll.Domain.Models.PollStats> PollStats);
        PollStatsDTO MapperToDTO(Poll.Domain.Models.PollStats PollStats);
    }
}
