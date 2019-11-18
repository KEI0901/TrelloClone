using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TrelloClone.Models
{
    public class TrelloCloneContext : DbContext
    {
        public TrelloCloneContext (DbContextOptions<TrelloCloneContext> options)
            : base(options)
        {
        }

        public DbSet<TrelloClone.Models.Board> Board { get; set; }
        public DbSet<TrelloClone.Models.TaskList> TaskList { get; set; }

        public DbSet<TrelloClone.Models.Task> Task { get; set; }
    }
}
