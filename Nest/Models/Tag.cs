﻿namespace Nest.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ProductTags> Tags { get; set; }
    }
}
