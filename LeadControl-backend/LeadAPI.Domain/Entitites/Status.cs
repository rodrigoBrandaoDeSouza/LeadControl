namespace LeadAPI.Domain.Entitites
{
    public class Status
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public LeadStatus LeadStatus { get; set; }
    }
}
