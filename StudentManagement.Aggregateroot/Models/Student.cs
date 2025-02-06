using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Aggregateroot.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public string Address { get; set; }
        public int Roll {  get; set; }
        public int ParentsCell { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }

    }
}
