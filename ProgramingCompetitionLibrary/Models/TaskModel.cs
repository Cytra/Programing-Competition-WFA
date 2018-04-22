using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ProgramingCompetitionLibrary.Models
{
    public class TaskModel
    {
        public int ID { get; set; }
        public string TaskName { get; set; }
        public string  TaskDescribtion { get; set; }
        public string TaskSolution { get; set; }
    }
}
