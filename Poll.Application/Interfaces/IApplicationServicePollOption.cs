using System.Collections.Generic;
using Poll.Application.DTO.DTO;

namespace Poll.Application.Interfaces
{
    public interface IApplicationServicePollOption
    {
        int Add(NewPollOptionDTO obj);
        PollOptionDTO GetById(int id);
        IEnumerable<PollOptionDTO> GetPollOptions(int id);
        void Dispose();
    }
}
