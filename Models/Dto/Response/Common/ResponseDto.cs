using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models.Dto.Response.Common
{
    public class ResponseDto<T>
    {
        public ResponseDto() { }
        public ResponseDto(T data) {
            Succeeded = true;
            Message = string.Empty;
            Errors = new List<string>();
            Data = data;
        }

        public T Data { get; set; }
        public bool Succeeded { get; set; }
        public List<string> Errors { get; set; }
        public string Message { get; set; }
    }
}
