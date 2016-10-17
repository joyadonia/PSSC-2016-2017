using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    public class Decanat
    {
        private List<string> _listaDisciplineFacultate;
        private Dictionary<Facultate,List<string>> _facultati=new Dictionary<Facultate,List<string>>();
        private Dictionary<Disciplina, List<Profesor>> _profesori;
        private Dictionary<Student, List<string>> _studentDiscipline;
        static Decanat _instance=null;
        private Decanat()
        {
        }
        public static Decanat GetInstance()
        {
            if(_instance!=null)
            {
                return new Decanat();
            }
            return _instance;
        }
        ///cand se adauga un student se vor adauga si in situatie disciplinele anului curent
    }
}
