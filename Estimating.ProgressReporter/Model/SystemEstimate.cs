﻿using Estimating.ProgressReporter.Interfaces.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estimating.ProgressReporter.Model
{
    public class SystemEstimate : ISystemEstimate
    {
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Type { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double PercentComplete { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<IPhaseCode> PhaseCodes { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int GetPhaseCodeCount()
        {
            throw new NotImplementedException();
        }
    }
}
