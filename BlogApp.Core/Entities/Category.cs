using BlogApp.Core.Entities.Common;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Core.Entities
{
    public record Category : BaseEntity
    {
        public string? Name { get; set; }
        public string? LogoUrl { get; set; }
        public List<Blog> Blogs { get; set; }
    }
}
