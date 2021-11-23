using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeverXCoursesLab10
{
    public class Group
    {
        public Guid Id {  get; set; }
        public string Name {  get; set; }
        public List<User> Users {  get; set; }
    }
}
