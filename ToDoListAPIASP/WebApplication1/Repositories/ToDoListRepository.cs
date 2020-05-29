using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication1.EF;
using WebApplication1.Models;

namespace WebApplication1.Repositories
{
    public class ToDoListRepository : IRepository<Task>
    {
        ToDoListContext db;
        public ToDoListRepository()
        {
            db = new ToDoListContext();
        }
        public ToDoListRepository(ToDoListContext context)
        {
            db = context;
        }
        public Task Create(Task item)
        {
            db.Tasks.Add(item);
            this.Save();
            return item;
        }

        public Task Get(int id)
        {
            Task task = db.Tasks.Find(id);
            return task;
        }

        public IEnumerable<Task> GetAll()
        {
            return db.Tasks.ToList();
        }

        public void Remove(int id)
        {
            Task task = Get(id);
            if (task != null)
            {
                db.Tasks.Remove(task);
                this.Save();
            }
        }

        public bool Update(Task item)
        {
            Task selected = Get(item.Id);
            if (selected != null)
            {
                selected.Description = item.Description;
                selected.Priority = item.Priority;
                selected.Deadline = item.Deadline;
                selected.State = item.State;
                db.Entry(selected).State= EntityState.Modified;
                this.Save();
                return true;
            }
            return false;
            }

        public void Save()
        {
            db.SaveChanges();
        }

        #region IDisposable Support
        private bool disposedValue = false; // Для определения избыточных вызовов

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: освободить управляемое состояние (управляемые объекты).
                }

                // TODO: освободить неуправляемые ресурсы (неуправляемые объекты) и переопределить ниже метод завершения.
                // TODO: задать большим полям значение NULL.

                disposedValue = true;
            }
        }

        // TODO: переопределить метод завершения, только если Dispose(bool disposing) выше включает код для освобождения неуправляемых ресурсов.
        // ~ToDoListRepository() {
        //   // Не изменяйте этот код. Разместите код очистки выше, в методе Dispose(bool disposing).
        //   Dispose(false);
        // }

        // Этот код добавлен для правильной реализации шаблона высвобождаемого класса.
        public void Dispose()
        {
            // Не изменяйте этот код. Разместите код очистки выше, в методе Dispose(bool disposing).
            Dispose(true);
            // TODO: раскомментировать следующую строку, если метод завершения переопределен выше.
            // GC.SuppressFinalize(this);
        }
        #endregion

    }
}