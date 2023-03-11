using HumanResourceManagementSystem.Domain.Entities.Identity;

namespace HumanResourceManagementSystem.Domain.Entities;

public sealed class Resume : BaseAuditableEntity
{
	public long UserId { get; set; }
	public User User { get; set; }
	public Guid? ProfileId { get; set; }
	public Profile? Profile { get; set; }
	public ICollection<Education>?  Educations { get; set; }
	public ICollection<Experience>? Experiences { get; set; }
	public ICollection<Skill>? Skills { get; set; }
	public ICollection<Reference>? References { get; set; }
	public ICollection<Certificate>? Certificates { get; set; }
	public ICollection<Project>? Project { get; set; }
}
