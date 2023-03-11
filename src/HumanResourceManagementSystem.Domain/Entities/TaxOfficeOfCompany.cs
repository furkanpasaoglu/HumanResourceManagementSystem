namespace HumanResourceManagementSystem.Domain.Entities;

public sealed class TaxOfficeOfCompany : BaseAuditableEntity
{
	public string TaxNumber { get; set; }
	public int TaxOfficeId { get; set; }
	public TaxOffice TaxOffice { get; set; }
	public long CompanyId { get; set; }
	public Company Company { get; set; }
}
