namespace HumanResourceManagementSystem.Domain.Entities;

public sealed class Country : BaseAuditableEntity
{
	public string Name { get; set; }
	public string Code { get; set; }
}
