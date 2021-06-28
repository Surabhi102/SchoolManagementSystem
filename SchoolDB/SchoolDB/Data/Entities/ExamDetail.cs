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
    public class ExamDetail
    {
 
        public int ExamId { get; set; }

        public int StudentId { get; set; }

        public int SubjectId{ get; set; }

        public int Score { get; set; }

   
        public string Remark { get; set; }

        public virtual Exam Exam { get; set; }

        public virtual Student Student { get; set; }

        public virtual Subject Subject { get; set; }

       
    }
    public class ExamDetailConfig : EntityTypeConfiguration<ExamDetail>
    {
        public ExamDetailConfig() {

           
            Property(e => e.Remark).HasMaxLength(40);
            HasKey(e => new { e.ExamId, e.StudentId,e.SubjectId });


        }
             
    }
}
