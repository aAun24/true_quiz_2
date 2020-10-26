using System;
using System.Collections.Generic;

namespace TrueQuizTwo.Models
{
    public partial class Address
    {
        public string AddressId { get; set; }
        public string UserId { get; set; }
        public string ProvinceId { get; set; }
        public string KhetId { get; set; }
        public string KhwangId { get; set; }
        public int? Zipcode { get; set; }
    }
}
