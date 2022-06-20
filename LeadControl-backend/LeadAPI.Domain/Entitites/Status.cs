namespace LeadAPI.Domain.Entitites
{
    public class Status
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public IEnumerable<LeadStatus> LeadStatus { get; set; }
    }
}
