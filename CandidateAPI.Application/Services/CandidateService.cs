using CandidateAPI.Core.Entities;
using CandidateAPI.Core.Interfaces;

namespace CandidateAPI.Application.Services
{
    public class CandidateService
    {
        private readonly ICandidateRepository _candidateRepository;
        public CandidateService(ICandidateRepository candidateRepository)
        {
            _candidateRepository = candidateRepository;
        }


        public async Task<Candidate> AddOrUpdateCandidateAsync(Candidate candidate)
        {
            var existingCandidate = await _candidateRepository.GetCandidateByEmailAsync(candidate.Email);

            if (existingCandidate == null)
            {
                await _candidateRepository.AddCandidateAsync(candidate);
            }
            else
            {
                existingCandidate.FirstName = candidate.FirstName;
                existingCandidate.LastName = candidate.LastName;    
                existingCandidate.PhoneNumber = candidate.PhoneNumber;
                existingCandidate.CallInterval = candidate.CallInterval;
                existingCandidate.LinkedInProfileUrl = candidate.LinkedInProfileUrl;
                existingCandidate.GitHubProfileUrl = candidate.GitHubProfileUrl;
                existingCandidate.Comment = candidate.Comment;
                await _candidateRepository.UpdateCandidateAsync(existingCandidate);
            }
            return candidate;
        }
    }
}
