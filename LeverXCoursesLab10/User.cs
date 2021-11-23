using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeverXCoursesLab10
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        [Required]
        public string EducationLevel { get; set; }
        public int Age { get; set; }
    }
}
