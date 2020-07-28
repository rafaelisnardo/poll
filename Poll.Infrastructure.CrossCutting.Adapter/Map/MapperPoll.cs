using Poll.Application.DTO.DTO;
using Poll.Infrastructure.CrossCutting.Adapter.Interfaces;
using System.Collections.Generic;

namespace Poll.Infrastructure.CrossCutting.Adapter.Map
{
    public class MapperPoll : IMapperPoll
    {
        #region properties
        List<PollDTO> PollDTOs = new List<PollDTO>();
        #endregion

        #region methods
        public Poll.Domain.Models.Poll MapperToEntity(string poll_description)
        {
            Poll.Domain.Models.Poll Poll = new Poll.Domain.Models.Poll
            {
                poll_description = poll_description
            };

            return Poll;
        }

        public IEnumerable<PollDTO> MapperListPolls(IEnumerable<Poll.Domain.Models.Poll> Polls)
        {
            foreach (var item in Polls)
            {
                PollDTO PollDTO = new PollDTO
                {
                    poll_id = item.poll_id,
                    poll_description = item.poll_description
                };

                PollDTOs.Add(PollDTO);
            }

            return PollDTOs;
        }

        public PollDTO MapperToDTO(Poll.Domain.Models.Poll Poll)
        {
            if (Poll != null)
            {
                PollDTO PollDTO = new PollDTO
                {
                    poll_id = Poll.poll_id,
                    poll_description = Poll.poll_description
                };

                return PollDTO;
            }
            else
            {
                return null;
            }
            
        }
        #endregion
    }
}
