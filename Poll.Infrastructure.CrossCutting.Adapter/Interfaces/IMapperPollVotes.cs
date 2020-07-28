using Poll.Application.DTO.DTO;
using System.Collections.Generic;

namespace Poll.Infrastructure.CrossCutting.Adapter.Interfaces
{
    public interface IMapperPollVotes
    {
        Poll.Domain.Models.PollVotes MapperToEntity(PollVotesDTO PollVotesDTO);
        IEnumerable<PollVotesDTO> MapperListPollVotes(IEnumerable<Poll.Domain.Models.PollVotes> PollVotes);
        PollVotesDTO MapperToDTO(Poll.Domain.Models.PollVotes PollVotes);
    }
}
