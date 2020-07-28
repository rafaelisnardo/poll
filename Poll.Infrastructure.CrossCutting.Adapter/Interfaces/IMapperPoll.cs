using Poll.Application.DTO.DTO;
using System.Collections.Generic;

namespace Poll.Infrastructure.CrossCutting.Adapter.Interfaces
{
    public interface IMapperPoll
    {
        Poll.Domain.Models.Poll MapperToEntity(string poll_description);
        IEnumerable<PollDTO> MapperListPolls(IEnumerable<Poll.Domain.Models.Poll> Polls);
        PollDTO MapperToDTO(Poll.Domain.Models.Poll Poll);
    }
}
