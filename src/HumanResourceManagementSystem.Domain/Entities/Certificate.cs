namespace HumanResourceManagementSystem.Domain.Entities;

public sealed class Certificate : BaseAuditableEntity
{
	public Guid ResumeId { get; set; }
	public Resume Resume { get; set; }
	public string Name { get; set; }
	public string OrganizationName { get; set; }
	public DateTime StartDate { get; set; }
	public DateTime EndDate { get; set; }
	public bool IsTemporary{ get; set; }
}
