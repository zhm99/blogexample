using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BlogP.Models;
using BlogP.Interfaces;

namespace BlogP.Controllers
{
    [Route("api/tags")]
    [ApiController]
    public class TagController : Controller
    {

        private readonly ITagService _tagService;

        public TagController(ITagService tagService)
        {
            _tagService = tagService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TagViewModel>>> GetTags()
        {
            var tags = await _tagService.GetTags();
            return Ok(tags);
        }
    }
}