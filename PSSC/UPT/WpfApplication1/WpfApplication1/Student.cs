using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WpfApplication1.Decanat;

namespace WpfApplication1
{
   public  class Student
    {

        private List<Disciplina> _disc;

        public List<Disciplina> Disc
        {
            get { return _disc; }
            set { _disc = value; }
        }


        public Dictionary<int, List<Disciplina>> Discipline
        {
            get { return _discipline; }
            set { _discipline = value; }
        }

        private Situatie _situatie;

        public Situatie Situatie
        {
            get { return _situatie; }
            set { _situatie = value; }
        }

        private string  _nume;
        private Dictionary<int, List<Disciplina>> _discipline;


        private Facultate _facultate;
        private string _an;
        public string An
        {
            get { return _an; }
            set { _an = value; }
        }
        private string _prenume;

        public string Prenume  
        {
            get { return _prenume; }
            set { _prenume = value; }
        }


        public string Nume  
        {
            get { return _nume; }
            set { _nume = value; }
        }
        private DateTime _data;

        public DateTime Data
        {
            get { return _data; }
            set { _data = value; }
        }
        private Facultate Facultate
        {
            get { return _facultate; }
            set { _facultate = value; }
        }

    }
}
