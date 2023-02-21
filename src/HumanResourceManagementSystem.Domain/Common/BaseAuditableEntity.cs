namespace HumanResourceManagementSystem.Domain.Common;

public class BaseAuditableEntity : BaseEntity
{
    public long CreatedBy { get; set; }
    public DateTime CreatedAt { get; set; }
    public long LastModifiedBy { get; set; }
    public DateTime LastModified { get; set; }
    public DateTime? DeletedAt { get; set; }
    public bool IsDeleted { get; set; }
    public string? DeletedBy { get; set; }
}