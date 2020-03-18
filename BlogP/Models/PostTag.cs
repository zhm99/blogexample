using BlogP.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogP.Models
{
    public class PostTag
    {
        /*[Key]
        public int PostTagId { get; set; }*/

        [ForeignKey("Post")]
        public int PostId { get; set; }

        public Post Post { get; set; }

        [ForeignKey("Tag")]
        public string TagId { get; set; }

        public Tag Tag { get; set; }

    }
}
