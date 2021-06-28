using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolDB.Data.Entities
{
    public class Class
    {
        public Class()
        {
            Subjects = new HashSet<Subject>();
            Exams = new HashSet<Exam>();
            Students = new HashSet<Student>();
        }
    
        public int ClassId { get; set; }

       
        public string Name { get; set; }

  
        public string Section { get; set; }

      
        public virtual ICollection<Subject> Subjects { get; set; }

       
        public virtual ICollection<Exam> Exams { get; set; }

        
        public virtual ICollection<Student> Students { get; set; }
    }



}
