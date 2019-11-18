using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrelloClone.Models
{
    public class Task
    {
        public int ID { get; set; }

        public int TaskListID { get; set; }

        public string Text { get; set; }
    }
}
