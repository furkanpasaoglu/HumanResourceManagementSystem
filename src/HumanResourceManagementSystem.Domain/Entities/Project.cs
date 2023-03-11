namespace HumanResourceManagementSystem.Domain.Entities;

public sealed class Project : BaseAuditableEntity
{
	public Guid ResumeId { get; set; }
	public Resume Resume { get; set; }
	public string Name { get; set; }
	public string Description { get; set; }
	public DateTime StartDate { get; set; }
	public DateTime FinishDate { get; set; }
	public string Url { get; set; }

}
