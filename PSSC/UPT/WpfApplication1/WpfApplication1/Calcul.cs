using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    public class Calcul
    {
       public  float calculMedieTotala(Student student)
        {
            float media=0;
           
            Nota nota2;
            List<Disciplina> discipline = student.Facultate.Discipline;
            int numarDiscipline=discipline.Count();
            foreach (Disciplina d in discipline)
            {
                student.Situatie.Note.TryGetValue(d, out nota2);
                media += calculNotaFinala(student,1/3,d);

            }
            return media/numarDiscipline;
        }
      public  float calculNotaFinala(Student student,float procent,Disciplina disciplina)
        {
             
            Nota nota2;
            student.Situatie.Note.TryGetValue(disciplina, out nota2);
          return  ((nota2.Activitate * procent) + (nota2.Evaluare.ElementAt(0) + nota2.Evaluare.ElementAt(1))) / 2;
            
        }
    }
}
