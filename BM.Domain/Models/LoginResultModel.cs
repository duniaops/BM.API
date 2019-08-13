using System;
namespace BM.Domain.Models
{
    public class LoginResultModel
    {
        public bool IsSucess { get; set; }
        public string Token { get; set; }
        public string Message { get; set; }
    }
}
