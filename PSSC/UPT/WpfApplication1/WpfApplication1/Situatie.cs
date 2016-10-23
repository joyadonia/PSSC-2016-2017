using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
   public class Situatie
    {
        
      
        private Dictionary<Disciplina,Nota> _note;
        public Dictionary<Disciplina, Nota> Note
            {
            get { return _note; }
            private  set { _note = value; }
            }
    }
}
