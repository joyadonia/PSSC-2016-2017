using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPT
{
    public class Bursa
    {
        public enum TypeBursa { sociala, deMerit, deExcelenta };
        private TypeBursa _tipBursa;
        public TypeBursa TipBursa
        {
            get {return _tipBursa; }
            set { _tipBursa = value; }
    }
        public virtual void CalculBursa()
        {

        } 

    }
}
