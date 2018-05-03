using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASPTask2_4.Models
{
    public class StudentModel
    {
        [Required]
        [MinLength(5)]
        [MaxLength(20)]
        public string Name { get; set; }

    }
}
