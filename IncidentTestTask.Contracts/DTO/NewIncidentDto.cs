namespace IncidentTestTask.Contracts.DTO
{
    public class NewIncidentDto
    {
        public string AccountName { get; set; }

        public string ContactFirstName { get; set; }

        public string ContactLastName { get; set; }

        public string ContactEmail { get; set; }

        public string IncidentDescript { get; set; }
    }
}