using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.EF
{
    public class ToDoListContext : DbContext
    {

        public ToDoListContext() : base()
        {
            //Database.SetInitializer<ToDoListContext>(new ToDoListInitializer());
            //Database.Initialize(true);
        }
        public DbSet<Task> Tasks { set; get; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(new ToDoListInitializer());
        }
    }
}