using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InputMask.Models
{
    public class LamiData
    {
        [Key]
        public Guid Id { get; set; }
        [Column(TypeName ="decimal(18,6)")]
        public decimal Number1 { get; set; }
    }
}
