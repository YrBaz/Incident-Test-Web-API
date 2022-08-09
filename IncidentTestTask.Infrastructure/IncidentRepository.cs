using IncidentTestTask.Application;
using IncidentTestTask.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace IncidentTestTask.Infrastructure
{
    public class IncidentRepository : IIncidentRepository
    {
        private readonly AppDbContext _dbContext;
        public IncidentRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<Account> GetAccounts()
        {
            return _dbContext.Accounts.Include(e => e.Incidents);
        }

        public async Task<string> CreateIncident(Incident incident)
        {
            if (incident == null)
            {
                throw new ArgumentNullException(nameof(incident));
            }

            _dbContext.Incidents.Add(incident);
            await _dbContext.SaveChangesAsync();

            return incident.Name;
        }

        public async Task CreateContact(string firstName, string lastName, string email)
        {
            var contact = await _dbContext.Contacts.FirstOrDefaultAsync(e => e.Email == email);

            if (contact == null)
            {
                contact = new Contact { Email = email };
                _dbContext.Contacts.Add(contact);
            }

            contact.FirstName = firstName;
            contact.LastName = lastName;

            await _dbContext.SaveChangesAsync();
        }

        public async Task<int> CreateAccount(Account account)
        {
            if (account == null)
            {
                throw new ArgumentNullException(nameof(account));
            }

            _dbContext.Accounts.Add(account);
            await _dbContext.SaveChangesAsync();

            return account.Id;
        }
    }
}