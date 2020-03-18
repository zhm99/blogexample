using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Slugify;

namespace BlogP.Helper
{
    public static class Helper
    {
        public static string GenerateSlug(string text)
        {
            SlugHelper slugGenerator = new SlugHelper();

            var slug = slugGenerator.GenerateSlug(text);
            return slug;
        }
    }
}
