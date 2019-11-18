using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TrelloClone.Models;

namespace TrelloClone.Controllers
{
    public class BoardsController : Controller
    {
        private readonly TrelloCloneContext _context;

        public BoardsController(TrelloCloneContext context)
        {
            _context = context;
        }

        // GET: Boards
        public async Task<IActionResult> Index()
        {
            return View(await _context.Board.ToListAsync());
        }


        private bool BoardExists(int id)
        {
            return _context.Board.Any(e => e.ID == id);
        }
    }
}
