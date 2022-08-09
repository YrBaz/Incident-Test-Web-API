using IncidentTestTask.Contracts.DTO;

namespace IncidentTestTask.Application
{
    public interface IIncidentService
    {
        Task<string> CreateIncident(NewIncidentDto model);
        Task<int> CreateAccount(NewAccountDto model);
    }
}