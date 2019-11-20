using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TrelloClone.Models;

namespace TrelloClone.Controllers
{
    public class TaskListController : Controller
    {

        private readonly TrelloCloneContext _context;

        public TaskListController(TrelloCloneContext context)
        {
            _context = context;
        }

        public IActionResult Index(int id)
        {
            this.ViewData["BoardName"] = this._context.Board.FirstOrDefault(b => b.ID == id).Name;
            var taskLists = this._context.TaskList.Where(t => t.BoardID == id);
            return View(taskLists);
        }
    }
}