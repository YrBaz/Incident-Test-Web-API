namespace IncidentTestTask.Domain.Entity
{
    public class Account
    {
        public Account()
        {
            Incidents = new List<Incident>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int ContactId { get; set; }

        public virtual Contact Contact { get; set; }

        public ICollection<Incident> Incidents { get; set; }
    }
}