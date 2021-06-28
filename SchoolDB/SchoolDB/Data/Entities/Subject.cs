using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
namespace SchoolDB.Data.Entities
{
    public class Subject
    {
        public Subject()
        {
            ExamDetails = new HashSet<ExamDetail>();
            Teachers = new HashSet<Teacher>();
        }

     
        public int SubjectId { get; set; }

       
        public string Name { get; set; }

        public int? ClassId { get; set; }

        public virtual Class Class { get; set; }

        public virtual ICollection<ExamDetail> ExamDetails { get; set; }

       
        public virtual ICollection<Teacher> Teachers { get; set; }



    }
  


}
