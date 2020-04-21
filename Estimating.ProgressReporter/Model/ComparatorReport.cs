using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estimating.ProgressReporter.Interfaces.Model
{
    public class ComparatorReport
    {
        //Holds a list of comparator results for systems that were reported on in the weekly report. 
        List<ComparatorResult> ReportedSystems;
        //If a system wasn't included in the weekly report, it will be added to a list of 'UnreportedSystems' to be included in the final report. 
        List<EstimateModel> UnreportedSystems;

    }
}
