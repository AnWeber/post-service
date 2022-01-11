using Geekiam.Domain.Requests.Posts;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Threenine.ApiResponse;

namespace Geekiam.Posts.Service.Features.Submit.Post;

public class Command : IRequest<SingleResponse<Response>>
{
    [FromBody] public Submission Post { get; set; }
        
}