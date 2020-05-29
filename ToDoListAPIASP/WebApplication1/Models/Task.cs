using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Task
    {
       
            public int Id { get; set; }
            public string Description { get; set; }
            public int Priority { get; set; }
            public string Deadline { get; set; }
            public bool State { get; set; }
       
    }
}