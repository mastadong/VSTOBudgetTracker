using Estimating.ProgressReporter.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estimating.ProgressReporter.Interfaces.Model
{
    public class ComparatorResult
    {
        string SystemName { get; set; }
        bool IsWorkCompleted { get; set; }
        List<PhaseCode> AssociatedPhaseCodes { get; set; }
        List<PhaseCode> CompletePhaseCodes { get; set; }
        List<PhaseCode> IncompletePhaseCodes { get; set; }

    }
}
