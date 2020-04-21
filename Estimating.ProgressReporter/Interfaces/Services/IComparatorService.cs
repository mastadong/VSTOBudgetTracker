using Estimating.ProgressReporter.Interfaces.Model;
using Estimating.ProgressReporter.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estimating.ProgressReporter.Interfaces.Services
{
    public interface IComparatorService<ISytemModelService, ReportModel, EstimateModel>
    {
        ReportModel _reportModel { get; }
        EstimateModel _estimateModel { get; }

        //The calling class is a system model service, which holds an empty ComparatorReport class.  
        IModelReportingService _systemModelService { get; set; }
        
        //List level
        double GetPercentComplete(SystemEstimate systemEstimate, SystemReport systemReport);
        bool IsSystemComplete(SystemEstimate systemEstimate, SystemReport systemReport);
        List<PhaseCode> GetUnfinishedPhaseCodes(SystemEstimate systemEstimate, SystemReport systemReport);
        List<PhaseCode> GetCompletedPhaseCodes(SystemEstimate systemEstimate, SystemReport systemReport);

        //High level
        /// <summary>
        /// Returns a ComparatorReport to the caller.  Implement by assigning '_systemModelService.ComparatorReport' to the result of this function.
        /// </summary>
        /// <param name="estimateModel"></param>
        /// <param name="reportModel"></param>
        /// <returns></returns>
        ComparatorReport Compare(EstimateModel estimateModel, ReportModel reportModel);



    }
}
