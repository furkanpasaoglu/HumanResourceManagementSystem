namespace HumanResourceManagementSystem.Domain.Entities;

public sealed class District : BaseAuditableEntity
{
	public string Name { get; set; }
	public int CityId { get; set; }
	public City City { get; set; }
}
