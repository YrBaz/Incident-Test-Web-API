namespace IncidentTestTask.Domain.Entity
{
    public class Contact
    {
        public Contact()
        {
            Accounts = new List<Account>();
        }

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public ICollection<Account> Accounts { get; set; }
    }
}