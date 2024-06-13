using CandidateAPI.Core.Entities;
using CandidateAPI.Core.Interfaces;
using CandidateAPI.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace CandidateAPI.Infrastructure.Repository
{
    public class CandidateRepository : ICandidateRepository
    {
        private readonly CandidateContext _context;

        public CandidateRepository(CandidateContext context)
        {
            _context = context;
        }

        public async Task AddCandidateAsync(Candidate candidate)
        {
            await _context.Candidates.AddAsync(candidate);
            await _context.SaveChangesAsync();
        }

        public async Task<Candidate> GetCandidateByEmailAsync(string email)
        {
            return await _context.Candidates.SingleOrDefaultAsync(c => c.Email == email);
        }

        public async Task UpdateCandidateAsync(Candidate candidate)
        {
            _context.Candidates.Update(candidate);
            await _context.SaveChangesAsync();
        }
    }
}
