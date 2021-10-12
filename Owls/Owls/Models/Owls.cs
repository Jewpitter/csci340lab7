using System;
using System.ComponentModel.DataAnnotations;

namespace Owls.Models
{
    public class Owls
    {
        public int ID { get; set; }
        public string Name { get; set; }
        [DataType(DataType.Date)]
        public DateTime Age { get; set; }
        public string Species { get; set; }
        public decimal Height { get; set; }
    }
}