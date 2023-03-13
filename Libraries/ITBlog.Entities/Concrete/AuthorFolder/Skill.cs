﻿using ITBlog.Entities.Concrete.EntityFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITBlog.Entities.Concrete.AuthorFolder
{
    public class Skill : BaseEntity
    {
        public string? SkillName { get; set; }

        public int? SkillLearntPercantage { get; set; }

        public virtual ICollection<Author> Authors { get; set; }
    }
}
