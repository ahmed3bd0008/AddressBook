using System;
using Entities.Modal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities.Configuration
{
    public class JobConfiguration : IEntityTypeConfiguration<Job>
    {
        public void Configure(EntityTypeBuilder<Job> builder)
        {
            builder.HasData(new { JobId = 1, JobName = "Teacher" },
                new { JobId = 2, JobName = "Software Enginering" },
                new { JobId = 3, JobName = "Docor" }
                );
        }
    }
}
