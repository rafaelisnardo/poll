using Poll.Application.DTO.DTO;
using Poll.Infrastructure.CrossCutting.Adapter.Interfaces;
using System.Collections.Generic;

namespace Poll.Infrastructure.CrossCutting.Adapter.Map
{
    public class MapperPollStats : IMapperPollStats
    {
        #region properties
        List<PollStatsDTO> PollStatsDTOs = new List<PollStatsDTO>();
        #endregion

        #region methods
        public Poll.Domain.Models.PollStats MapperToEntity(PollStatsDTO PollStatsDTO)
        {
            Poll.Domain.Models.PollStats PollStats = new Poll.Domain.Models.PollStats
            {
                stat_id = PollStatsDTO.stat_id,
                poll_id = PollStatsDTO.poll_id,
                views = PollStatsDTO.views
            };

            return PollStats;
        }

        public IEnumerable<PollStatsDTO> MapperListPollStats(IEnumerable<Poll.Domain.Models.PollStats> PollStats)
        {
            foreach (var item in PollStats)
            {
                PollStatsDTO PollStatsDTO = new PollStatsDTO
                {
                    stat_id = item.stat_id,
                    poll_id = item.poll_id,
                    views = item.views
                };

                PollStatsDTOs.Add(PollStatsDTO);
            }

            return PollStatsDTOs;
        }

        public PollStatsDTO MapperToDTO(Poll.Domain.Models.PollStats PollStats)
        {
            if (PollStats != null)
            {
                PollStatsDTO PollStatsDTO = new PollStatsDTO
                {
                    stat_id = PollStats.stat_id,
                    poll_id = PollStats.poll_id,
                    views = PollStats.views
                };

                return PollStatsDTO;
            }
            else
            {
                return null;
            }
        }
        #endregion
    }
}
