using Microsoft.EntityFrameworkCore;

namespace Poll.Infrastructure.Data
{
    public class PollContext : DbContext
    {
        public PollContext() { }

        public PollContext(DbContextOptions<PollContext> options) : base(options) { }

        public virtual DbSet<Poll.Domain.Models.Poll> Poll { get; set; }
        public virtual DbSet<Poll.Domain.Models.PollOption> PollOption { get; set; }
        public virtual DbSet<Poll.Domain.Models.PollVotes> PollVotes { get; set; }
        public virtual DbSet<Poll.Domain.Models.PollStats> PollStats { get; set; }
    }
}