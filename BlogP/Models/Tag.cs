using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using BlogP.Models;

namespace BlogP.Models
{
    [Table("Tag")]
    public class Tag
    {
        [Key]
        public string TagId { get; set; }

        public List<PostTag> PostTags { get; set; }

    }
}
