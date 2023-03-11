namespace HumanResourceManagementSystem.Domain.Entities;

public sealed class Language : BaseAuditableEntity
{
	public Guid ResumeId { get; set; }
	public Resume Resume { get; set; }
	public decimal Level { get; set; }
}
