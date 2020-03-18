using BlogP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogP.Repositories
{
    public interface IPostRepository
    {
        Task<BlogPostViewModel> GetVM(string slug);
        Task<Post> Get(string slug);
        Task<IEnumerable<BlogPostViewModel>> Search(string tag);
        Task<BlogPostViewModel> Create(Post post);
        Task<Post> Update(Post post);
        Task Remove(string slug);
    }
}
