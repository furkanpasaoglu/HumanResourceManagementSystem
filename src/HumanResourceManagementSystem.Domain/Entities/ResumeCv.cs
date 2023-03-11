using HumanResourceManagementSystem.Domain.Entities.Identity;

namespace HumanResourceManagementSystem.Domain.Entities;

public sealed class ResumeCv : BaseAuditableEntity
{
	public long UserId { get; set; }
	public User User { get; set; }
	public string FileName { get; set; }
	public string FileExtension { get; set; }
	public string File { get; set; }

}
