using System;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolDB.Data.Entities
{
    public class Attendence
    {
        public int AtendenceId { get; set; }

        public int? StudentId { get; set; }

       
        public DateTime? Date { get; set; }

      
        public string Status { get; set; }

        public virtual Student Student { get; set; }

    }

    public class AttendenceConfig : EntityTypeConfiguration<Attendence>
    {
        public AttendenceConfig()
        {
            HasKey(e => e.AtendenceId);
        }
    }


}
