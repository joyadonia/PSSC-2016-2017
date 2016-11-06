using Models.Generics;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decanat
{
    public class SubjectInformation
    {
        public PlainText Name { get; internal set; }
        public Credits Credits { get; internal set; }
        public Professor Professor { get; internal set; }
        public Proportion ActivityProportion { get; internal set; }
        public EvaluationType Evaluation { get; internal set; }

        public SubjectInformation()
        {

        }

        public SubjectInformation(PlainText name, Credits credits, EvaluationType type, Proportion activity)
        {
            Name = name;
            Credits = credits;
            Evaluation = type;
            ActivityProportion = activity;
        }

        public SubjectInformation(PlainText name, Credits credits, EvaluationType type, Proportion activity, Professor professor)
            : this(name, credits, type, activity)
        {
            Professor = professor;
        }

        public void SetProfessor(Professor professor)
        {
            Professor = professor;
        }

        public void SetActivityProportion(Proportion proportion)
        {
            ActivityProportion = proportion;
        }
    }
}
