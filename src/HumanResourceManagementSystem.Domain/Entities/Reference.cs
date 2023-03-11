namespace HumanResourceManagementSystem.Domain.Entities;

public sealed class Reference : BaseAuditableEntity
{
	public Guid ResumeId { get; set; }
	public Resume Resume { get; set; }
	public string FirstName { get; set; }
	public string LastName { get; set; }
	public string FullName => $"{FirstName} {LastName}";
	public string Email { get; set; }
	public string Phone { get; set; }
	public string CompanyName { get; set; }
	public string PositionName { get; set; }
}
