using HumanResourceManagementSystem.Domain.Entities.Identity;

namespace HumanResourceManagementSystem.Domain.Entities;

public sealed class ResumeOfAdvertisement : BaseAuditableEntity
{
	public Guid AdvertisementId { get; set; }
	public Advertisement Advertisement { get; set; }
	public Guid CompanyId { get; set; }
	public Company Company { get; set; }
	public Guid ResumeId { get; set; }
	public Resume Resume { get; set; }
	public long UserId { get; set; }
	public User User { get; set; }

}
