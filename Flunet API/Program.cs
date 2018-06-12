using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flunet_API
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var efDbContext = new EfDbContext())
            {
                //efDbContext.Blogs.Add(new Blog()
                //{
                //    Name="刘圣",
                //    Url="http://www.baidu.com"
                //});
                //efDbContext.SaveChanges();
                //var errors = efDbContext.GetValidationErrors();
               
            }
        }
    }
}
