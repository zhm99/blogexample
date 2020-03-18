using BlogP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogP.Interfaces
{
    public interface IPostService
    {
        Task<BlogPostViewModel> GetPostVM(string slug);
        Task<Post> GetPost(string slug);
        Task<IEnumerable<BlogPostViewModel>> Search(string tag);
        Task<BlogPostViewModel> Create(Post post);
        Task<Post> Update(Post post);
        Task Delete(string slug);

    }
}
