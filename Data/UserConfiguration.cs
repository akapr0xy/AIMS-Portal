using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AIMS_Portal.Features;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AIMS_Portal.Data
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(x => x.Email).HasMaxLength(64);
            builder.HasIndex(x => x.Email).IsUnique();
        }
    }
}
