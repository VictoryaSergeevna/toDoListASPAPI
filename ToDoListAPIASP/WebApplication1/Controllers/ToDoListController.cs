using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;
using WebApplication1.Repositories;

namespace WebApplication1.Controllers
{
    public class ToDoListController : ApiController
    {
        IRepository<Task> db;
        public ToDoListController(IRepository<Task> rep)
        {
            db = rep;
        }
        public IEnumerable<Task> GetAll()
        {
            return db.GetAll();
        }

        public Task GetTask(int id)
        {
            return db.Get(id);
        }

        public Task PostTask(Task task)
        {
            return db.Create(task);
        }

        public bool PutTask(Task task)
        {
            return db.Update(task);
        }

        public void DeleteTask(int id)
        {
            db.Remove(id);
        }

    }
}
