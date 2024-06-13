using CandidateAPI.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace CandidateAPI.Infrastructure.Data
{
    public class CandidateContext : DbContext
    {
        public CandidateContext(DbContextOptions<CandidateContext> options) : base(options) { }
        public DbSet<Candidate> Candidates { get; set; }

    }

    
}
