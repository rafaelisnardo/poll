using Poll.Application.DTO.DTO;
using Poll.Infrastructure.CrossCutting.Adapter.Interfaces;
using System.Collections.Generic;

namespace Poll.Infrastructure.CrossCutting.Adapter.Map
{
    public class MapperPollVotes : IMapperPollVotes
    {
        #region properties
        List<PollVotesDTO> PollVotesDTOs = new List<PollVotesDTO>();
        #endregion

        #region methods
        public Poll.Domain.Models.PollVotes MapperToEntity(PollVotesDTO PollVotesDTO)
        {
            Poll.Domain.Models.PollVotes PollVotes = new Poll.Domain.Models.PollVotes
            {
                vote_id = PollVotesDTO.vote_id,
                poll_id = PollVotesDTO.poll_id,
                option_id  = PollVotesDTO.option_id,
                qty = PollVotesDTO.qty
            };

            return PollVotes;
        }

        public IEnumerable<PollVotesDTO> MapperListPollVotes(IEnumerable<Poll.Domain.Models.PollVotes> PollVotes)
        {
            foreach (var item in PollVotes)
            {
                PollVotesDTO PollVotesDTO = new PollVotesDTO
                {
                    vote_id = item.vote_id,
                    poll_id = item.poll_id,
                    option_id = item.option_id,
                    qty = item.qty
                };

                PollVotesDTOs.Add(PollVotesDTO);
            }

            return PollVotesDTOs;
        }

        public PollVotesDTO MapperToDTO(Poll.Domain.Models.PollVotes PollVotes)
        {
            if (PollVotes != null)
            {
                PollVotesDTO PollVotesDTO = new PollVotesDTO
                {
                    vote_id = PollVotes.vote_id,
                    poll_id = PollVotes.poll_id,
                    option_id = PollVotes.option_id,
                    qty = PollVotes.qty
                };

                return PollVotesDTO;
            }
            else
            {
                return null;
            }
        }
        #endregion
    }
}
