using CandidateAPI.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidateAPI.Core.Interfaces
{
    public interface ICandidateRepository
    {
        Task<Candidate> GetCandidateByEmailAsync(string email);
        Task AddCandidateAsync(Candidate candidate);
        Task UpdateCandidateAsync(Candidate candidate);
    }
}
