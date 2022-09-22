using Absher.Application.Features.Posts.Commands.CreatePost;
using Absher.Application.Features.Posts.Queries.GetPostDetail;
using Absher.Application.Features.Posts.Queries.GetPostsList;
using Absher.Domain;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Absher.Application.Profiles
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Post,GetPostsListViewModel>().ReverseMap();
            CreateMap<Post,GetPostDetailViewModel>().ReverseMap();
            CreateMap<Post,CreatePostCommand>().ReverseMap();
        }
    }
}
