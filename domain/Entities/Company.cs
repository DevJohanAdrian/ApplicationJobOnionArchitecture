using Domain.Common;

namespace Domain.Entities
{
    public class Company : AuditableBaseEntity
    {
        public string CompanyName { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
    }
}
