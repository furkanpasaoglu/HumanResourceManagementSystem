using HumanResourceManagementSystem.Domain.Entities.Identity;

namespace HumanResourceManagementSystem.Domain.Entities;

public sealed class Advertisement : BaseAuditableEntity
{
    public Guid CompanyId { get; set; }
    public Company Company { get; set; }
    public Guid DepartmentId { get; set; }
    public Department Department { get; set; }
    public long UserId { get; set; }
    public User User { get; set; }
    public decimal ExperienceStart { get; set; }
    public decimal ExperienceEnd { get; set; }
    public string Description { get; set; }
    public bool IsCvRequired { get; set; }
}
