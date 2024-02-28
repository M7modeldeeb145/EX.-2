using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class Course
    {
        public int CourseId { get; set; }
        [MaxLength(80)]
        [Unicode(true)]
        public string Name { get; set; }
        [Unicode(false)]
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        [Precision(10,2)]
        public decimal price { get; set; }
        public List<Student> Students { get; set; }
        public List<Resource> Resources { get; set; }
        public List<Homework> Homeworks { get; set; }
    }
}
