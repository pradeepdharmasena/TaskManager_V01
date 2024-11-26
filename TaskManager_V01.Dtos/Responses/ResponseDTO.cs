using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager_V01.Dtos.Responses
{
    public class ResponseDTO<T1, T2>
    {
        public required T1 Data { get; set; }
        public required T2 Error { get; set; }

        public ResponseDTO(T1 Data, T2 Error)
        {
            this.Data = Data;
            this.Error = Error;
        }
    }
}
