namespace Poll.Application.DTO.DTO
{
    public class PollVotesDTO
    {
        public int vote_id { get; set; }
        public int poll_id { get; set; }
        public int option_id { get; set; }
        public int qty { get; set; }
    }
}
