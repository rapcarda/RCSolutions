using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RCSolutions.Core.Entities;

namespace RCSolutions.Infra.Mappings
{
    public class CompanyMapping : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Code)
                .HasColumnName("Code")
                .HasColumnType("int");

            builder.Property(x => x.Name)
                .HasColumnName("Name")
                .HasColumnType("varchar(100)");

            builder.Property(x => x.Name)
                .HasColumnName("TradeName")
                .HasColumnType("varchar(200)");
        }
    }
}
