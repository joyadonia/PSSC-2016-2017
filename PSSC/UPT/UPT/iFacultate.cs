using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPT
{
    interface iFacultate
    {
        void setAn();
        void setFacultate();
        void setGrupa();
        void setSubGrupa();
        void setMaterii(List<Materie> materii);
    }
}
