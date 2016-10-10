using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPT
{
   public  class Universitate
    {
        public List<Profesor> _profesori;
        public  List<Facultate> _facultati;
        public List<Profesor> Profesori { get; set; }
        public List<Facultate> Facultati { get; set; }
        public List<Recontractare> _recontractari;
        public List<Recontractare> Recontractari { get; set; }
        public List<Extensie> _extensii;
        public List<Extensie> Extensii { get; set; }
        public List<Bursa> _burse;
        public List<Bursa> Burse { get; set; }
    }
}
