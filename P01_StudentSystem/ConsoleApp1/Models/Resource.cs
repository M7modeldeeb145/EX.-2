using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public enum ResourceType
    {
        video, presentation, Document, Other
    }
    internal class Resource
    {
        public int ResourceId { get; set; }
        public string Name { get; set; }
        [Unicode(false)]
        public string Url { get; set; }
        public ResourceType ResourceType { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
