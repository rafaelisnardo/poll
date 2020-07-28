using System.Collections.Generic;
using Poll.Application.DTO.DTO;

namespace Poll.Application.Interfaces
{
    public interface IApplicationServicePoll
    {
        int Add(NewPollDTO obj);
        PollDTO GetById(int id);
        void Dispose();
    }
}
