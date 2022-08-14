using MediatrAndCQRSDemo.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MediatrAndCQRSDemo.Configurations
{
    public class EducationalInfoConfiguration : IEntityTypeConfiguration<EducationalInfo>
    {
        public void Configure(EntityTypeBuilder<EducationalInfo> builder)
        {
            builder.Property(ei => ei.Id).ValueGeneratedNever();
            builder.Property(ei => ei.HighestDegree).HasColumnType("string");
            builder.Property(ei => ei.PersonalInfoId);
        }
    }
}
