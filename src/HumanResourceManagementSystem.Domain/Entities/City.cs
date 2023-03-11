namespace HumanResourceManagementSystem.Domain.Entities;

public sealed class City : BaseAuditableEntity
{
	public string Name { get; set; }
	public int CountryId { get; set; }
	public Country Country { get; set; }
}
