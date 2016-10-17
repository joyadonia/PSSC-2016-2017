using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
  public  class Disciplina
    {
        public enum TipExamen { distribuita, examen};
        private TipExamen _tip;
        private string _denumire;
        private Nota _nota;
        public Nota Nota
        {
            get { return _nota; }
            set { _nota = value; }
        }
        public string Denumire
        {
            get { return _denumire; }
            set { _denumire = value; }
        }

        private int _credite;

        public int Credite
        {
            get { return _credite; }
            set { _credite = value; }
        }
       

        public TipExamen Tip
        {
            get { return _tip; }
            set { _tip = value; }
        }


    }
}
