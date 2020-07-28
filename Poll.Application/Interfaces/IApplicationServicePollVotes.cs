using System.Collections.Generic;
using Poll.Application.DTO.DTO;

namespace Poll.Application.Interfaces
{
    public interface IApplicationServicePollVotes
    {
        int Add(PollVotesDTO obj);
        PollVotesDTO GetById(int id);
        IEnumerable<PollVotesDTO> GetPollVotes(int poll_id);
        IEnumerable<PollVotesDTO> GetPollVotes(int poll_id, int option_id);
        void Update(PollVotesDTO obj);
        void Dispose();
    }
}
