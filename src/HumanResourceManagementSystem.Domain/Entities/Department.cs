namespace HumanResourceManagementSystem.Domain.Entities;

public class Department : BaseAuditableEntity
{
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
}