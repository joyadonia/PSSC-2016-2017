using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    public class Calcul
    { 
       public   static  float calculMedieTotala(Student student,Disciplina.TipExamen tip)
        {
            float media=0;
           
            Nota nota2;
            var discipline = student.Discipline.SelectMany(x=>x.Value);
            int numarDiscipline=discipline.Count();
            foreach (Disciplina d in discipline)
            {
                student.Situatie.Note.TryGetValue(d, out nota2);
                media += calculNotaFinala(student,1/3,d,tip);

            }
            return media/numarDiscipline;
        }
      public static float calculNotaFinala(Student student,float procent,Disciplina disciplina, Disciplina.TipExamen tip)
        {
             
            Nota nota2;
            student.Situatie.Note.TryGetValue(disciplina, out nota2);
            // ia notele cele mai mare, se iau in calcul maririle 
            float max = nota2.Evaluare.Max();
            float max2 = nota2.Evaluare2.Max();
            if (tip.Equals(Disciplina.TipExamen.examen))
            {
                return ((nota2.Activitate * procent) + (nota2.Evaluare.IndexOf(max)*(100-procent)));
            }
            else
            {
                return ((nota2.Activitate * procent) + ((nota2.Evaluare.IndexOf(max) + nota2.Evaluare2.IndexOf(max2)*(100-procent))));
            }
        }
    }
}
