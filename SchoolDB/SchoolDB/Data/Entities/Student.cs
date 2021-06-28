using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace SchoolDB.Data.Entities
{
    public class Student
    {
        public Student()
        {
            Attendences = new HashSet<Attendence>();
            ExamDetails = new HashSet<ExamDetail>();
        }
        public int StudentId { get; set; }


        public string Name { get; set; }

        public int? ClassId { get; set; }

      
        public string FatherName { get; set; }

    
        public string Contact { get; set; }

       
        public string Address { get; set; }

    
        public virtual ICollection<Attendence> Attendences { get; set; }

        public virtual Class Class { get; set; }

       
        public virtual ICollection<ExamDetail> ExamDetails { get; set; }
    }
}
