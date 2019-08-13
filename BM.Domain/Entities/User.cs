using System;
namespace BM.Domain.Entities
{
    public class User : EntityBase
    {
        public string Username { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Pwd { get; set; }
    }
}
