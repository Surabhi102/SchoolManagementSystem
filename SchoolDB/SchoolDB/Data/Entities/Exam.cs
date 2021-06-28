using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;


namespace SchoolDB.Data.Entities
{
    public class Exam
    {
        public Exam()
        {
            ExamDetails = new HashSet<ExamDetail>();
        }

        public int ExamId { get; set; }

      
        public string Name { get; set; }


        public string Date { get; set; }

        public int? ClassId { get; set; }

        public virtual Class Class { get; set; }

        public virtual ICollection<ExamDetail> ExamDetails { get; set; }

    }
   
}
