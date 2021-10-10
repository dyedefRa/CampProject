using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampProject.EntityLayer.Concrete
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string SmallImage { get; set; }
        public string Image { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool Status { get; set; }

        public virtual Category Category { get; set; }
        public virtual List<Comment> Comments { get; set; }
    }
}
