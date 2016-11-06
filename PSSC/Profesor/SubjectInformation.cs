using Models.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profesor
{
    public class SubjectInformation
    {
        public PlainText Name { get; }
        public Credits Credits { get;  }
        public Professor Professor { get;  }
        public Proportion ActivityProportion { get; }
        public EvaluationType Evaluation { get;  }

        //public SubjectInformation()
        //{

        //}

        //public SubjectInformation(PlainText name, Credits credits, EvaluationType type, Proportion activity)
        //{
        //    Name = name;
        //    Credits = credits;
        //    Evaluation = type;
        //    ActivityProportion = activity;
        //}

        

        
        
    }
}
