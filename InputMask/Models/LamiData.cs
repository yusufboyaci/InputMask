using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InputMask.Models
{
    public class LamiData
    {
        [Key]
        public Guid Id { get; set; }
        public decimal Number1 { get; set; }
    }
}
