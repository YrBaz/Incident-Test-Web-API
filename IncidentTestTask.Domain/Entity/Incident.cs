using System.ComponentModel.DataAnnotations;

namespace IncidentTestTask.Domain.Entity
{
    public class Incident
    {
        [Key]
        public string Name { get; set; }
       
        public string Description { get; set; }
        
        public int AccountId { get; set; }
        
        public virtual Account Account { get; set; }
    }
}