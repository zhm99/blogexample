using BlogP.Interfaces;
using BlogP.Models;
using BlogP.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogP.Services
{
    public class TagService : ITagService
    {
        private readonly ITagRepository _tagRepository;

        public TagService(ITagRepository tagRepository)
        {
            _tagRepository = tagRepository;
        }

        public async Task<TagViewModel> GetTags()
        {
            var tags = await _tagRepository.GetAllTags();
            return tags;
        }
    }
}
