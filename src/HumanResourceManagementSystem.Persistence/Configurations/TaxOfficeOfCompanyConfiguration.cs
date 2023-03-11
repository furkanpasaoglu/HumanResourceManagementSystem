using HumanResourceManagementSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HumanResourceManagementSystem.Persistence.Configurations;

public class TaxOfficeOfCompanyConfiguration : IEntityTypeConfiguration<TaxOfficeOfCompany>
{
	public void Configure(EntityTypeBuilder<TaxOfficeOfCompany> builder)
	{
		throw new NotImplementedException();
	}
}

