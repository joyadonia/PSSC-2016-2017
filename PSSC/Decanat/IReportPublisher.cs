using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Models.Generics;

namespace Decanat
{
    
        //Strategy Signature
        public interface IReportStrategy
        {
           // PlainText GenerateReport(List<Decanat.Student> students);
        }

        //Strategy Context
        public interface IReportPublisher
        {
            void Publish(IReportStrategy strategy);
        }
    
}
