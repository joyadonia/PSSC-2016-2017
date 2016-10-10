using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPT
{
    public class Facultate : iFacultate
    {
        
        private List<string> _materii;

        public List<string> Materii
        {
            get { return _materii; }
            set { _materii = value; }
        }

        private List<Student> studenti;

        void iFacultate.setAn()
        {
            throw new NotImplementedException();
        }

        void iFacultate.setFacultate()
        {
            throw new NotImplementedException();
        }

        void iFacultate.setGrupa()
        {
            throw new NotImplementedException();
        }

        void iFacultate.setMaterii(List<Materie> materii)
        {
            throw new NotImplementedException();
        }

        void iFacultate.setSubGrupa()
        {
            throw new NotImplementedException();
        }
    }
}
