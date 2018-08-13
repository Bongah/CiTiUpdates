using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CiTiUpdates.Models
{
    public class Personal
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string IdNumber { get; set; }
        public string CellNumber{ get; set; }
        public string Email { get; set; }
        public string StreetAddress { get; set; }
        public string City{ get; set; }
        public string State{ get; set; }
        public string Province{ get; set; }
        public int Zip { get; set; }

    }
}