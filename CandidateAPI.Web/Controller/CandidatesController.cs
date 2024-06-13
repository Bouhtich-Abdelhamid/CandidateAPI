using CandidateAPI.Application.Services;
using CandidateAPI.Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CandidateAPI.Web.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class CandidatesController : ControllerBase
    {
        private readonly CandidateService _candidateService;
        public CandidatesController(CandidateService candidateService)
        {
            _candidateService = candidateService;
        }

        [HttpPost]
        public async Task<IActionResult> AddOrUpdateCandidate([FromBody] Candidate candidate)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result= await _candidateService.AddOrUpdateCandidateAsync(candidate);
            return Ok(result);
        }


    }
}
