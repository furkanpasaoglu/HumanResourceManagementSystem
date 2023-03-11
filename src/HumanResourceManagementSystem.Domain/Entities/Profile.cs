using HumanResourceManagementSystem.Domain.Enums;

namespace HumanResourceManagementSystem.Domain.Entities;

public sealed class Profile : BaseAuditableEntity
{
	public Guid ResumeId { get; set; }
	public Resume Resume { get; set; }
	public string FirstName { get; set; }
	public string LastName { get; set; }
	public string FullName => $"{FirstName} {LastName}";
	public string About { get; set; }
	public string Email { get; set; }
	public DateTime BirthDate { get; set; }
	public int Age => DateTime.Now.Year - BirthDate.Year;
	public Genders Gender { get; set; }
	public string WebSiteUrl { get; set; }


}
