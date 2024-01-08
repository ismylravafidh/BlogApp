using BlogApp.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.DAL.Configuration
{
    public class BlogConfiguration : IEntityTypeConfiguration<Blog>
    {
        public void Configure(EntityTypeBuilder<Blog> builder)
        {
            builder.Property(b => b.Title).IsRequired();
            builder.Property(b=>b.Description).IsRequired();
            builder.HasOne(b => b.User).WithMany(b => b.Blogs);
            builder.HasOne(b => b.Category).WithMany(b => b.Blogs);
        }
    }
}
