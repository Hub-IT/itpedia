﻿using System.Collections.Generic;

namespace ItPedia.Models
{
    public class SolutionCategory
    {
        public virtual int SolutionCategoryId { get; set; }
        public virtual string Name { get; set; }

        public virtual List<Solution> Solutions { get; set; }
    }
}