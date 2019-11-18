using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrelloClone.Models
{
    public class Board
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public ICollection<TaskList> TaskLists { get; set; }
    }
}
