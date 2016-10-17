using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
   public  class Student
    {
        private string  _nume;
         
        
        private Facultate _facultate;
        private string _an;

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
       public Facultate Facultate
        {
            get { return _facultate; }
            set { _facultate = value; }
        }

    }
}
