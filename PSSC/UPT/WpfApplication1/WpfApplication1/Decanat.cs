using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    public class Decanat
    {
      //  private List<Facultate> _facultati = new List<Facultate>();
      //  private Dictionary<Facultate,List<string>> _listaDisciplineFacultate=new Dictionary<Facultate,List<string>>();
        private Dictionary<Disciplina, List<Profesor>> _profesori;
        private Dictionary<Student, List<string>> _studentDiscipline;
        static Decanat _instance=null;
        public Dictionary<Student, List<string>> StudentDiscipline
        {
            get { return _studentDiscipline; }
            set { _studentDiscipline = value; }
        }
       public  Dictionary<Disciplina, List<Profesor>> Profesori
        {
            get { return _profesori; }
           set  { _profesori = value; }
        }
        //public List<Facultate> Facultati
        //{
        //    get { return _facultati; }
            
        //}
        //public Dictionary<Facultate, List<string>>   ListaDisciplineFacultate
        //{
        //    get { return _listaDisciplineFacultate; }
        //    set { _listaDisciplineFacultate = value; }
        //}
        private Decanat()
        {
            Facultate facultate = new Facultate("Automatica si Calculatoare");
            facultate.Discipline.Add(1, new List<string>() { "Algebra", "Programare C", "Tehnici de programare", "Logica digitala" });


        }
        public static Decanat GetInstance()
        {
            if(_instance!=null)
            {
                return new Decanat();
            }
            return _instance;
        }
        ///cand se adauga un student se vor adauga si in situatie disciplinele anului curent
        ///



        protected internal class Facultate
        {
            private List<Student> _studenti;
            private Dictionary<int, List<Disciplina>> _discipline;
            private List<Profesor> _profesori;
            private string _nume;

            public string Nume
            {
                get { return _nume; }
                set { _nume = value; }
            }


            public List<Student> Studenti
            {
                get { return _studenti; }
                set { _studenti = value; }
            }
            public Dictionary<int, List<Disciplina>> Discipline
            {
                get { return _discipline; }
                set { _discipline = value; }
            }
            public List<Profesor> Profesori
            {
                get { return _profesori; }
                set { _profesori = value; }
            }

            public Facultate(string nume)
            {
                Nume = nume;
            }
        }
    }
}
