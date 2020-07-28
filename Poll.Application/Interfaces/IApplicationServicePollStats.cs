using System.Collections.Generic;
using Poll.Application.DTO.DTO;

namespace Poll.Application.Interfaces
{
    public interface IApplicationServicePollStats
    {
        int Add(PollStatsDTO obj);
        PollStatsDTO GetById(int id);
        IEnumerable<PollStatsDTO> GetPollStats(int poll_id);
        void Update(PollStatsDTO obj);
        void Dispose();
    }
}
