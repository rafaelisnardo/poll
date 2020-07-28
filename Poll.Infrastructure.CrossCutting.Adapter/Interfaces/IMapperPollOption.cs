using Poll.Application.DTO.DTO;
using System.Collections.Generic;

namespace Poll.Infrastructure.CrossCutting.Adapter.Interfaces
{
    public interface IMapperPollOption
    {
        Poll.Domain.Models.PollOption MapperToEntity(NewPollOptionDTO PollOptionDTO);
        IEnumerable<PollOptionDTO> MapperListPollOptions(IEnumerable<Poll.Domain.Models.PollOption> PollOptions);
        PollOptionDTO MapperToDTO(Poll.Domain.Models.PollOption PollOption);
    }
}
