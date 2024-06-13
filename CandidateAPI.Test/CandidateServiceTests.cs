using CandidateAPI.Application.Services;
using CandidateAPI.Core.Entities;
using CandidateAPI.Core.Interfaces;
using Moq;
using Xunit;

namespace CandidateAPI.Test
{
    public class CandidateServiceTests
    {
        [Fact]
        public async Task AddOrUpdateCandidateAsync_NewCandidate_AddsCandidate()
        {
            var mockRepository = new Mock<ICandidateRepository>();
            mockRepository.Setup(repo => repo.GetCandidateByEmailAsync("test@example.com")).ReturnsAsync((Candidate)null);

            var service = new CandidateService(mockRepository.Object);
            var candidate = new Candidate { Email = "Test@test.com", FirstName = "Abdelhamid", LastName = "Bouhtich", Comment = "job Test" };

            //act
            var result = await service.AddOrUpdateCandidateAsync(candidate);

            //assert
            mockRepository.Verify(repo => repo.AddCandidateAsync(candidate), Times.Once);

        }


    }
}
