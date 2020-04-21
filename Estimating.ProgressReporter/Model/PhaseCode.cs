using Estimating.ProgressReporter.Interfaces.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estimating.ProgressReporter.Model
{
    public class PhaseCode : IPhaseCode
    {
        public string FullPhaseCode { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string PhaseCodeSuffix { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public PhaseCodeCategory PhaseCodePrefix { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int EstimatedHours { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime DateCompleted { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

}
