using HumanResourceManagementSystem.Domain.Entities.Identity;

namespace HumanResourceManagementSystem.Domain.Entities;

public sealed class Address : BaseAuditableEntity
{
	public string Description { get; set; }
	public long UserId { get; set; }
	public User User { get; set; }
	public int CountryId { get; set; }
	public Country Country { get; set; }
	public int CityId { get; set; }
	public City City { get; set; }
	public int DistrictId { get; set; }
	public District District { get; set; }

}
