using Decanat;
using Models.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    
        public class SubjectSituation
        {   
            public Attendance Attendance { get; }
            public List<Grade> ExamGrades { get; }
            public Grade ActivityGrade { get;  }

            public SubjectSituation()
            {

            }

            

           

            public decimal GetExamAverage(EvaluationType type)
            {
                Grade average;

                if (type.Equals(EvaluationType.Distributed))
                {
                    average = new Grade((ExamGrades[0].Value + ExamGrades[1].Value) / 2);
                }
                else
                {
                    average = new Grade(ExamGrades[0].Value);
                }

                return average.Value;
            }
        }
    

}
