namespace HumanResourceManagementSystem.Domain.Entities;

public sealed class Skill : BaseAuditableEntity
{
	public Guid ResumeId { get; set; }
	public Resume Resume { get; set; }
	public string Name { get; set; }

}
