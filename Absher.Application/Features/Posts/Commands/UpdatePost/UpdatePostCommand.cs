using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Absher.Application.Features.Posts.Commands.UpdatePost
{
    public class UpdatePostCommand:IRequest
    {
        public Guid Id { get; set; }
        public String Title { get; set; }
        public String ImageUrl { get; set; }
        public String Content { get; set; }
        public Guid CategoryId { get; set; }
    }
}
