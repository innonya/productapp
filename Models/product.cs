using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.VisualBasic.CompilerServices;

namespace ElectroniTrading.Models
{
    public class product
    {
      
        public int Id { get; set; }
        public string name { get; set; }

        public string description { get; set; }
        public string image { get; set; }
    }
}