using BlogP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogP.Interfaces
{
    public interface ITagService
    {
        Task<TagViewModel> GetTags();
    }
}
