using HumanResourceManagementSystem.Domain.Enums;

namespace HumanResourceManagementSystem.Domain.Entities;

public sealed class Experience : BaseAuditableEntity
{
	public Guid ResumeId { get; set; }
	public Resume Resume { get; set; }
	public string CompanyName { get; set; }
	public Guid SectorId{ get; set; }
	public Sector Sector { get; set; }
	public DateTime StartDate { get; set; }
	public DateTime? EndDate { get; set; }
	public Guid WorkPositionId { get; set; }
	public WorkPosition WorkPosition { get; set; }
	public WorkTypes WorkType { get; set; }
}
