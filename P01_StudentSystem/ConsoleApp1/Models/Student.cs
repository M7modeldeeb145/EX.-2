using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public  DateTime RegisteredOn { get; set; }
        public DateTime BirthDay { get; set; }
        public List<Course> Courses { get; set; }
        public List<Homework> Homeworks { get; set; }


    }
}
