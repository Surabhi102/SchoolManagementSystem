using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolDB.Data.Entities
{
   public  class Teacher
    {
        public Teacher()
        {
            Subjects = new HashSet<Subject>();
        }

       
        public int TeacherId { get; set; }

      
        public string Name { get; set; }

       
        public int? Contact { get; set; }

      
        public string VehicleId { get; set; }

        public string Education { get; set; }

        public virtual ICollection<Subject> Subjects { get; set; }
    }
}
