namespace HumanResourceManagementSystem.Domain.Entities;

public sealed class TaxOffice : BaseAuditableEntity
{
	public string Name { get; set; }
	public string Code { get; set; }
	public int CityId { get; set; }
	public City City { get; set; }
}
