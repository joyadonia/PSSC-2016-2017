using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace UPT
{
   public class Recontractare
    {
        
        private string _materie;
        private string _an;
        private string _profesor;
         
        public string Materie
        {
            set { _materie = value; }
            get { return _materie; }
        }

    

        public string An
        {
            get { return _an; }
            set { _an = value; }
        }
        

        public string Profesor
        {
            get { return _profesor; }
            set { _profesor = value; }
        }

    }
}

     
