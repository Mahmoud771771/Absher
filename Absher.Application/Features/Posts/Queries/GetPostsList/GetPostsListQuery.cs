using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Absher.Application.Features.Posts.Queries.GetPostsList
{
    public class GetPostsListQuery:IRequest<List<GetPostsListViewModel>>
    {
    }
}
