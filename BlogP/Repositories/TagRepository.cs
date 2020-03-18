
using BlogP.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogP.Repositories
{
    public class TagRepository : ITagRepository
    {
        private readonly BlogPContext _context;

        public TagRepository(BlogPContext context)
        {
            _context = context;
        }

        public async Task<TagViewModel> GetAllTags()
        {
            var tags = await _context.Tag.ToListAsync();

            TagViewModel model = new TagViewModel()
            {
                Tags = new List<string>()
            };


            model.Tags = tags.Select(x => x.TagId).ToList();

            return model;
        }
    }
}
