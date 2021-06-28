using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using SchoolDB.Data.Entities;

namespace SchoolDB.Data
{
    class SchoolContext:DbContext
    {
        public SchoolContext() : base("SchoolDB")
        {

        }

        protected override void OnModelCreating(DbModelBuilder builder)
        {
          
            builder.Configurations.Add(new ExamDetailConfig());
            builder.Configurations.Add(new AttendenceConfig());


        }


        public virtual DbSet<Attendence> Attendences { get; set; }
        public virtual DbSet<Class> Classes { get; set; }
        public virtual DbSet<Exam> Exams { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<ExamDetail> ExamDetails { get; set; }
    }
}
