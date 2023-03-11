namespace HumanResourceManagementSystem.Domain.Entities;

public sealed class Education : BaseAuditableEntity
{
	public Guid ResumeId { get; set; }
	public Resume Resume { get; set; }
	public string Name { get; set; }
	public string SectionName { get; set; }
	public DateTime StartDate { get; set; }
	public DateTime? EndDate { get; set; }
	public decimal GradeAverage { get; set; }
	public bool Status { get; set; }
}
