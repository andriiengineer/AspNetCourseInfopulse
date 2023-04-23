using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HW4.Models
{
    public class Hobby
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Desciption { get; set; } = string.Empty;
        public InvolvementLevel Involved { get; set; }
    }

    public enum InvolvementLevel
    {
        Low,
        Medium,
        High
    }
}