using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogP.Models;
using BlogP.Repositories;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace BlogP.Repositories
{
    public class PostRepository : IPostRepository
    {

        private readonly BlogPContext _context;
        private readonly object Mapper;

        public object Mapper { get; private set; }

        public PostRepository(BlogPContext context)
        {
            _context = context;
        }

        public async Task<BlogPostViewModel> GetVM(string slug)
        {
            var post = await Get(slug);

            var postMap = Mapper.Map<BlogPostViewModel>(post);

            return postMap;
                   
        }

        public async Task<Post> Get(string slug)
        {
            var post = await _context.Post.Include(x => x.PostTags).ThenInclude(y => y.Tag).FirstOrDefaultAsync(x => x.Slug == slug);

            if (post == null)
            {
                return null;
            }

            post.TagList = post.PostTags.Select(x => x.TagId).ToList();
            return post;
        }


        public async Task<IEnumerable<BlogPostViewModel>> Search(string tag)
        {

            var posts = await _context.Post.Include(x => x.PostTags).ThenInclude(x => x.Tag).ToListAsync();

            if (!string.IsNullOrWhiteSpace(tag))
            {
                posts = posts.Where(x => x.PostTags.Any(y => y.TagId == tag)).ToList();
            }

            foreach (var post in posts)
            {
                post.TagList = post.PostTags?.Select(x => x.Tag.TagId).ToList();
            }

            var listOfPosts = Mapper.Map<IEnumerable<BlogPostViewModel>>(posts);


            return listOfPosts;
        }

        public async Task<BlogPostViewModel> Create(Post post)
        {
            post.Slug = Helper.Helper.GenerateSlug(post.Title);
            post.CreatedAt = DateTime.UtcNow;
            _context.Post.Add(post);

            if (post.TagList == null || post.TagList.Count == 0)
                goto noTags;

            post.PostTags = new List<PostTag>();

            var dbTags = _context.Tag.Select(x => x.TagId);

            foreach (var tag in post.TagList)
            {
                if (!dbTags.Contains(tag))
                {
                    _context.Tag.Add(new Tag() { TagId = tag });
                }

                PostTag postTag = new PostTag()
                {
                    TagId = tag,
                    PostId = post.PostId
                };

                post.PostTags.Add(postTag);

            }
            noTags: await _context.SaveChangesAsync();
            var postVM = Mapper.Map<BlogPostViewModel>(post);
            return postVM;
        }

        public async Task<Post> Update(Post post)
        {
            _context.Update(post);
            await _context.SaveChangesAsync();
            return post;

        }

        public async Task Remove(string slug)
        {
            var post = _context.Post.FirstOrDefault(x => x.Slug == slug);
            _context.Post.Remove(post);
            await _context.SaveChangesAsync();
        }

        Task<Post> IPostRepository.Get(string slug)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<BlogPostViewModel>> IPostRepository.Search(string tag)
        {
            throw new NotImplementedException();
        }

        Task<BlogPostViewModel> IPostRepository.Create(Post post)
        {
            throw new NotImplementedException();
        }

        Task<Post> IPostRepository.Update(Post post)
        {
            throw new NotImplementedException();
        }

        Task IPostRepository.Remove(string slug)
        {
            throw new NotImplementedException();
        }
    }
}
