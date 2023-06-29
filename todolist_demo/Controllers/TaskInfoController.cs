using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using todolist_demo.Models;

namespace todolist_demo.Controllers
{
    public class TaskInfoController : Controller
    {
        // GET: TaskInfo

        private ApplicationDbContext _context;

        public TaskInfoController()
        {
            _context=new ApplicationDbContext();
        }
        public ActionResult Index()
        {
            var taskInfo = _context.TaskInfo.ToList();
            // return Content("raj");
            return View(taskInfo);
        }

        public ActionResult Task_Form()
        {
            return View("Task_Form");
        }

        [HttpPost]
        public ActionResult Save(TaskInfo task)
        {
          
            if (task.Id == 0)
            {
               task.Created = DateTime.Now;
              
                _context.TaskInfo.Add(task);
            }
           
            _context.SaveChanges();
            return RedirectToAction("Index", "TaskInfo");
        }
    }
}