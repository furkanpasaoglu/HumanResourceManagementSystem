namespace HumanResourceManagementSystem.Domain.Entities;

public sealed class Company : BaseAuditableEntity
{
	public string Name { get; set; }
	public string About { get; set; }
	public int NumberOfEmployees { get; set; }
	public string Benefits { get; set; }
	public string WebSiteUrl { get; set; }
	public long AddressId { get; set; }
	public Address Address { get; set; }
	public int TaxOfficeId { get; set; }
	public TaxOffice TaxOffice { get; set; }
}
