using HumanResourceManagementSystem.Domain.Entities.Identity;

namespace HumanResourceManagementSystem.Domain.Entities;

public sealed class CompanyDetail : BaseAuditableEntity
{
	public long UserId { get; set; }
	public User User { get; set; }
	public long CompanyId { get; set; }
	public Company Company { get; set; }
	public long TaxOfficeOfCompanyId { get; set; }
	public TaxOfficeOfCompany TaxOfficeOfCompany { get; set; }
}
