namespace HumanResourceManagementSystem.Domain.Entities;

public sealed class SectorOfCompany : BaseAuditableEntity
{
	public Guid CompanyId { get; set; }
	public Company Company { get; set; }
	public Guid SectorId { get; set; }
	public Sector Sector { get; set; }
}
