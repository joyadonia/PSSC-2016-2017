using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    public class Profesor 
    {
        public Calcul _calcul;
        private Laborator _laborator;

        public Laborator Laborator
        {
            get { return _laborator; }
            set { _laborator = value; }
        }

        private List<string> _studenti;
        public List<string> Studenti
        {
            get { return _studenti; }
            set { _studenti = value; }
        }

        private string _prenume;

        public string Prenume
        {
            get { return _prenume; }
            set { _prenume = value; }
        }
        private string _nume;

        public string Nume
        {
            get { return _nume; }
            set { _nume = value; }
        }
        private int _procent;

        public int Procent
        {
            get { return _procent; }
            set { _procent = value; }
        }


        public void adaugaNotaExamen(Student student, Disciplina disciplina, Nota nota, float nota1,  int an, float nota2=0)
        {
            var index = student.Disc.IndexOf(disciplina);
            if (disciplina.Tip.Equals(Disciplina.TipExamen.examen))
            {
                //// daca nu exista note(studentul nu a mai fost la alte prezentari)
                if (student.Disc.ElementAt(index).Nota.Evaluare.Count != 0)
                {
                    student.Disc.ElementAt(index).Nota.Evaluare.Add(nota1);
                }
                else
                {
                    float max = student.Disc.ElementAt(index).Nota.Evaluare.Max();
                    if(nota1 > max)
                    {
                        student.Disc.ElementAt(index).Nota.Evaluare.Add(nota1);
                    }
                }
            }
            else
            {    
                  if(student.Disc.ElementAt(index).Nota.Evaluare.Count!=0)
                {
                    var max = student.Disc.ElementAt(index).Nota.Evaluare.Max();
                    if(nota1>max)
                    {
                        student.Disc.ElementAt(index).Nota.Evaluare.Add(nota1);
                    }
                }
                  else
                {
                    student.Disc.ElementAt(index).Nota.Evaluare.Add(nota1);
                   
                }
                  if (student.Disc.ElementAt(index).Nota.Evaluare2.Count != 0)
                {
                    var max = student.Disc.ElementAt(index).Nota.Evaluare2.Max();
                    if (nota2 > max)
                    {
                        student.Disc.ElementAt(index).Nota.Evaluare2.Add(nota2);
                    }
                }
                  else
                {
                    student.Disc.ElementAt(index).Nota.Evaluare2.Add(nota2);
                }

            }
        }
        /// <summary>
        /// adaugare note in situatia fiecarui elev in parte
        /// </summary>
        /// <param name="student"></param>
        /// <param name="disciplina"></param>
        /// <param name="nota"></param>
        public void adaugaNoteInSituatie(Student student,Disciplina disciplina, Nota nota)
        {
            student.Situatie.Note.Add(disciplina, nota);
        }

        
    }
}
