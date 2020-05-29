using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.EF
{
    public class ToDoListInitializer : DropCreateDatabaseIfModelChanges<ToDoListContext>
    {
        protected override void Seed(ToDoListContext context)
        {

            IList<Task> tasks = new List<Task>();
            tasks.Add(new Task() { Description = "Сделать зарядку", Priority=3, Deadline="14.04.2020", State = true });
            tasks.Add(new Task() { Description = "Приготовить кушать", Priority = 4, Deadline = "14.04.2020", State = true });
            tasks.Add(new Task() { Description = "Позвонить маме", Priority = 4, Deadline = "14.04.2020", State = true });
            tasks.Add(new Task() { Description = "Убрать в доме", Priority = 3, Deadline = "14.04.2020", State = true});
            tasks.Add(new Task() { Description = "Поучить уроки с детьми", Priority = 5, Deadline = "14.04.2020", State = true });
            tasks.Add(new Task() { Description = "Убрать во дворе", Priority = 2, Deadline = "14.04.2020", State = false });
            tasks.Add(new Task() { Description = "Поработать", Priority = 5, Deadline = "14.04.2020", State = true });
            tasks.Add(new Task() { Description = "Сделать дз", Priority = 5, Deadline = "14.04.2020", State = true });
            tasks.Add(new Task() { Description = "Помыть машину", Priority = 3, Deadline = "14.04.2020", State = false });
            tasks.Add(new Task() { Description = "Купить продукты", Priority = 2, Deadline = "14.04.2020", State = false });

            context.Tasks.AddRange(tasks);
            context.SaveChanges();
            // base.Seed(context);
        }

    }
}