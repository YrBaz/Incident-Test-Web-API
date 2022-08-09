using IncidentTestTask.Contracts.DTO;
using IncidentTestTask.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace IncidentTestTask.Application
{
    public class IncidentService : IIncidentService
    {
        private readonly IIncidentRepository _incidentRepository;

        public IncidentService(IIncidentRepository incidentRepository)
        {
            _incidentRepository = incidentRepository;
        }

        public async Task<int> CreateAccount(NewAccountDto model)
        {
            await _incidentRepository.CreateContact(model.ContactFirstName, model.ContactLastName, model.ContactEmail);

            var account = new Account
            {
                Name = model.AccountName
            };

            var accountId = await _incidentRepository.CreateAccount(account);

            return accountId;
        }

        public async Task<string> CreateIncident(NewIncidentDto model)
        {
            var account = await _incidentRepository.GetAccounts().FirstOrDefaultAsync(e => e.Name == model.AccountName);

            if (account == null)
            {
                throw new ArgumentNullException(nameof(account));
            }

            await _incidentRepository.CreateContact(model.ContactFirstName, model.ContactLastName, model.ContactEmail);

            var incident = new Incident
            {
                AccountId = account.Id,
                Name = "incident-" + Guid.NewGuid(),
                Description = model.IncidentDescript
            };

            var incidentName = await _incidentRepository.CreateIncident(incident);

            return incidentName;
        }
    }
}