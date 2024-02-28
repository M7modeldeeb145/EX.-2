using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public enum ContentType
    {
        app, pdf, zip
    }
    internal class Homework
    {
        public int HomeworkId { get; set; }
        [Unicode(false)]
        public string Content { get; set; }
        public ContentType ContentType { get; set; }
        public DateTime SumissionTime { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public Student Student { get; set; }
        public Course Course { get; set; }
    }
}
