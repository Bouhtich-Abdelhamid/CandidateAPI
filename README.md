# CandidateAPI:
CandidateAPI is a RESTful API project built using .NET that allows managing job candidate information. It provides endpoints for creating, updating, and retrieving candidate profiles.

# Features
- Create Candidate: Add a new candidate profile with details such as name, contact information, social profiles, and comments;
- Update Candidate: Modify existing candidate profiles;
- Retrieve Candidate: Get candidate details by email address;
- Database Integration: Uses Entity Framework Core for database interactions, initially configured for SQL Server;

# Requirements:
- .NET 5 SDK or later
- Visual Studio 2019 or Visual Studio Code (optional for development)
- SQL Server (or another supported database for deployment)

# database:
- Open appsettings.json in the CandidateAPI.Web project.
- Modify the DefaultConnection string under "ConnectionStrings" to point to your SQL Server instance.

# Migration:
- run command : dotnet ef database update -p CandidateAPI.Infrastructure -s CandidateAPI.Web

then run the project


# Improvements 
there are many things that can be improved:
- Error Handling: Implement centralized error handling middleware to manage exceptions uniformly across the application.

- Logging: Integrate a logging framework to capture detailed logs for monitoring and troubleshooting purposes.

- Security: Enhance security measures by implementing authentication and authorization mechanisms to control access to API endpoints.