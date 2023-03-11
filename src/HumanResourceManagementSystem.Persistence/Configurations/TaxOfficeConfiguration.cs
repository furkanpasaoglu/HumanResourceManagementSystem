using HumanResourceManagementSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HumanResourceManagementSystem.Persistence.Configurations;

public class TaxOfficeConfiguration : IEntityTypeConfiguration<TaxOffice>
{
	public void Configure(EntityTypeBuilder<TaxOffice> builder)
	{
		throw new NotImplementedException();
	}
}

