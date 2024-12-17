using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager_V01.Models
{
    public class TaskAssignee
    {
        public int TaskId { get; set; }
        public Task Task { get; set; } = null!;
        public string UserID { get; set; } = string.Empty;
        public User UserAccount { get; set; } = null!;
    }
}
