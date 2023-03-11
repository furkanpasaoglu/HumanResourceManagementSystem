using HumanResourceManagementSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HumanResourceManagementSystem.Persistence.Configurations;

public class CompanyDetailConfiguration : IEntityTypeConfiguration<CompanyDetail>
{
	public void Configure(EntityTypeBuilder<CompanyDetail> builder)
	{
		throw new NotImplementedException();
	}
}

