using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
   public class Laborator
    {
        private int _numarPrezente;

        public int NumarPrezente
        {
            get { return _numarPrezente; }
        
        }

        private string _materie;

        public string Materie
        {
            get { return _materie; }
            set { _materie = value; }
        }
        public void prezente(Student student, Disciplina d)
        {
            _numarPrezente++;
        }

    }
}
