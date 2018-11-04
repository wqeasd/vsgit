using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new CourseDBEntities())
            {
                var departments = context.Cou.OrderBy(n => n.SortCode).ToList();
                foreach (var a in departments)
                    Console.WriteLine("编号{0},部门名称{1}，说明{2}", a.SortCode, a.Name, a.Dscn);
                Console.ReadKey();
            }
        }
    }
}
