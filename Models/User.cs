using System;
using System.Collections.Generic;

namespace TrueQuizTwo.Models
{
    public partial class User
    {
        public int No { get; set; }
        public string Userid { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string AddressId { get; set; }
        public int Phone { get; set; }
        public string Uername { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string LateUpdateBy { get; set; }
        public DateTime LateUpdateDate { get; set; }
    }
}
