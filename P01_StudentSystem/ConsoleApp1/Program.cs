using ConsoleApp1.Data;
using ConsoleApp1.Models;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SeedData();
        }
        public static void SeedData()
        {
            StudentSystemContext context = new StudentSystemContext();
            List<Student> students = new List<Student>
        {
            new Student() {Name="Mahmoud",PhoneNumber="01019320991",BirthDay=DateTime.Now},
            new Student() {Name="Mohamed",PhoneNumber="01214547855",BirthDay=DateTime.Now}
        };
            context.Students.AddRange(students);
            context.SaveChanges();
            var Courses = new List<Course>
        {
            new Course{Name="Kafr Delhab",Description="Adventure",price=1200,StartDate=DateTime.Now,EndDate=DateTime.Now},
            new Course{Name="3b8foor",Description="Drama",price=1240,StartDate=DateTime.Now,EndDate=DateTime.Now}
        };
            context.Courses.AddRange(Courses);
            context.SaveChanges();
            var Resources = new List<Resource>
        {
            new Resource{Name="Google",ResourceType=ResourceType.Document,Url="wwww.Google.com",},
            new Resource{Name="Yahoo",ResourceType=ResourceType.Other,Url="wwww.yahoo.com"}
        };
            context.Resources.AddRange(Resources);
            context.SaveChanges();
            var Homeworks = new List<Homework>
        {
            new Homework{Content="Scientific",ContentType=ContentType.pdf},
            new Homework{Content="Comedy",ContentType=ContentType.zip}
        };
            context.Homeworks.AddRange(Homeworks);
            context.SaveChanges();
        }
    }
}

