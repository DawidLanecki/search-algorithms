using System;
using System.Collections.Generic;
using System.Linq;
namespace SearchAlgorithms.Core.Testing.Timers
{
    public class RichTimeMeasure : TimeMeasure
    {
        private double ReferrentialUnit;

        public RichTimeMeasure(Action functionToMeasure, double referentialUnit): base(functionToMeasure)
        {
            this.ReferrentialUnit = referentialUnit;
        }

        new public double Measure()
        {
            return base.Measure() / this.ReferrentialUnit;
        }
    }
}
