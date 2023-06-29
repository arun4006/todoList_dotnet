using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace todolist_demo.Models
{
    public class TaskInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
       
        public DateTime Created { get; set; }   
    }
}