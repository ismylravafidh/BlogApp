using BlogApp.Core.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Core.Entities
{
    public record Blog : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string? CoverImageUrl { get; set; }
        public string UserId { get; set; }
        public AppUser User { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
