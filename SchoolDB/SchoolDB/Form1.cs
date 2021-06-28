using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolDB.Data;
using SchoolDB.Data.Entities;
namespace SchoolDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
            SetupData();
        }

        BackgroundWorker bw;
        private void SetupData()
        {
            lblProcess.Text = "Setting up data please wait...";

            bw = new BackgroundWorker();
            bw.DoWork += Bw_DoWork;
            bw.RunWorkerCompleted += Bw_RunWorkerCompleted;

            bw.RunWorkerAsync();
        }
        private void Bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lblProcess.Text = e.Result.ToString();
        }
        private void Bw_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {

                using (var ctx = new SchoolContext())
                {
                    if (!ctx.Classes.Any())
                    {
                        var Classe = new List<Class>()
                            {
                            new Class()
                            {
                                Name = "First",
                                Section = "A",
                                Subjects = new List<Subject>()
                                {
                                    new Subject()
                                    {
                                        Name = "English"
                                    },
                                    new Subject()
                                    {
                                        Name = "Social"
                                    },
                                    new Subject()
                                    {
                                        Name = "Maths"
                                    }
                                }

                            },
                             new Class()
                            {
                                Name = "Secound",
                                Section = "A",
                                Subjects = new List<Subject>()
                                {
                                    new Subject()
                                    {
                                        Name = "English"
                                    },
                                    new Subject()
                                    {
                                        Name = "Social"
                                    },
                                    new Subject()
                                    {
                                        Name = "Maths"
                                    }
                                }

                            },

                            };
                        ctx.Classes.AddRange(Classe);
                    }
                  

                    if (!ctx.Students.Any())
                    {
                       

                            var student = new List<Student>()
                            {
                            new Student()
                            {
                                Name = "Krishna",
                                ClassId = 1,
                                FatherName = "Govind",
                                Contact = "7338235834",
                                Address = "Mysuru"
                            },
                            new Student()
                            {
                                Name = "Mayur",
                                ClassId = 1,
                                FatherName = "Keshv",
                                Contact = "7338235834",
                                Address = "Mysuru"
                            },
                            };
                            ctx.Students.AddRange(student);
                        }

                    
                    ctx.SaveChanges();
                    e.Result = "Ready";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
      


//Inserting Students
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var ctx = new SchoolContext())
                {
                    if (!ctx.Exams.Any())
                    {

                        var exam = new Exam()
                        {
                            Name = "FirestIA",
                            ClassId = 1,
                            Date = "25-06-21",
                            ExamDetails = new List<ExamDetail>()
                                {
                                    new ExamDetail()
                                    {
                                        StudentId = 1,
                                        Score = 25,
                                        SubjectId = 1,
                                        Remark = "Good Job"

                                    },
                                      new ExamDetail()
                                    {
                                        StudentId = 2,
                                        Score = 20,
                                        SubjectId = 1,
                                        Remark = "Can do better"

                                    }


                                }

                        };
                        ctx.Exams.Add(exam);

                    }
                    ctx.SaveChanges();

                    MessageBox.Show("Sucess");
                }
              


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using(var ctx = new SchoolContext())
            {



                var clas = ctx.Classes.FirstOrDefault();
                var exam = clas?.Exams.Where(a => a.ExamId == 1);
                decimal sum = 0;
                int count = 0;
                if (exam.Any())
                {
                    var exams = exam.SelectMany(b => b.ExamDetails);
                    count = exams.Count();
                    if (exams.Any()) sum = exams.Sum(c => c.Score);
                }
                
                var msg = $" The average Score of {count} students is {sum/count}";
                MessageBox.Show(msg);






            }
        }
    }
}
