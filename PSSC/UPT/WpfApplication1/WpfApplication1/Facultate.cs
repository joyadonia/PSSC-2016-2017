using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
  public  class Facultate
    {
        private List<Student> _studenti;
        private List<Disciplina> _discipline;
        private List<Profesor> _profesori;
         

        public List<Student> Studenti
        {
            get { return _studenti; }
            set { _studenti = value; }
        }
        public List<Disciplina> Discipline
        {
            get { return _discipline; }
            set { _discipline = value; }
        }
        public List<Profesor> Profesori
        {
            get { return _profesori; }
            set { _profesori = value; }
        }

    }
}
