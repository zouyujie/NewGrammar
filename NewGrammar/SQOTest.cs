using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewGrammar
{
    public class SQOTest
    {
        private List<User> InitLstData()
        {
          return new List<User>(){
          new User { Id = 1, Name = "Zouqj1", Age = 21 }, 
          new User { Id = 2, Name = "Zouqj2", Age = 22 },
          new User { Id = 3, Name = "Zouqj3", Age = 23 },
          new User { Id = 4, Name = "Zouqj4", Age = 24 },
          new User { Id = 5, Name = "Zouqj5", Age = 25 },
          new User { Id = 6, Name = "Zouqj6", Age = 26 },
          new User { Id = 7, Name = "Zouqj7", Age = 27 },
          new User { Id = 8, Name = "Zouqj8", Age = 28 },
          new User { Id = 9, Name = "Zouqj9", Age = 29 },
          new User { Id = 10, Name = "Zouqj10", Age = 30 },
          new User { Id = 11, Name = "Zouqj11", Age = 31 }
           };
        }
        public void Test()
        {
            var lst = InitLstData();

            //var result = lst.Where(x => x.Age >= 30).ToList();
            //result.ForEach(r => Console.WriteLine(string.Format("{0},{1},{2}", r.Id, r.Name, r.Age)));
            //Console.ReadLine();

            //var result = lst.Where(x => x.Age >= 30).Select(s => s.Name).ToList();
            //result.ForEach(x => Console.WriteLine(x));

            lst.Where(x => x.Age >= 30).Count();

            lst.OrderBy(x => x.Age).OrderBy(x => x.Id);
            IEnumerable<User> usr = lst.Where(x => x.Age >= 30);
            List<User> lstUsr = lst.FindAll(x => x.Age >= 30);

            List<Student> lstStu = new List<Student>() { new Student{ID=1,UserId=1,ClassName="本科8班"},
                new Student{ID=1,UserId=3,ClassName="本科2班"},new Student{ID=1,UserId=2,ClassName="电信1班"}};

            var result = lst.Join(lstStu, u => u.Id, p => p.UserId, (u, p) => new { UserId = u.Id, Name = u.Name, ClassName =p.ClassName});
        }
    }
    public class Student
    {
        public int ID { get; set; }
        public int UserId { get; set; }
        public string ClassName { get; set; }
    }
}
