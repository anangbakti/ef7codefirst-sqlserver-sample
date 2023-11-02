using ConsoleApp1.EntityDataModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Test1DbContext : DbContext
    {

        public Test1DbContext(DbContextOptions<Test1DbContext> options) : base (options){ 
        
        }

        public DbSet<Person> Persons { get; set; }  

    }
}
