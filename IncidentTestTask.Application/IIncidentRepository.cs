using IncidentTestTask.Domain.Entity;

namespace IncidentTestTask.Application
{
    public interface IIncidentRepository
    {
        IQueryable<Account> GetAccounts();
        Task CreateContact(string firstName, string lastName, string email);
        Task<string> CreateIncident(Incident incident);
        Task<int> CreateAccount(Account account);
    }
}