using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Flunet_API.EfDbContext.Order;

namespace Flunet_API
{
    class EfDbContext:DbContext
    {
        public EfDbContext():base("name=ConnectionString")
        {
            DbModelBuilder modelBuilder = new DbModelBuilder();
            Database.SetInitializer<EfDbContext>(new DropCreateDatabaseIfModelChanges<EfDbContext>());
            //modelBuilder.Entity<Order>().ToTable("Orders");
            //modelBuilder.ComplexType(Address);
        }
        public DbSet<Order> Orders { get; set; }
        //public DbSet<StudentAddress> StudentAddresses { get; set; }
        //public DbSet<Blog> Blogs { get; set; }
        //public DbSet<Department> Departments { get; set; }
        public class Department
        {
            //Primaryt key
            public int DepartmentID { get; set; }
            public string Name { get; set; }

            //Navigation property
            public virtual ICollection<Course> Courses { get; set; }
        }

        public class Course
        {
            //主键
            public int CourseID { get; set; }
            public string Title { get; set; }
            public int Credits { get; set; }
            //外键
            public int DepartmentID { get; set; }
            //导航关联
            public virtual Department Department { get; set; }
        }

        public class StudentAddress
        {
            public int AddressId { get; set; }
            public int StudentId { get; set; }
        }

        //复杂类型约定
        public class Order
        {
            public int Id;
            public string Name;

            public class Address
            {
                public string Street;
                public string Region;
                public string Country;
            }
        }
    }
}
