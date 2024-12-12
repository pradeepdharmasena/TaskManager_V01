using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager_V01.Dtos
{
    public class AppResponse<T>
    {
        public T? Data { get; set; }
        public CustomError? Error { get; set; }
    }
}
