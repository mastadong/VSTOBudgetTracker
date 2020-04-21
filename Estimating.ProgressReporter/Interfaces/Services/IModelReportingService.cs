using Estimating.ProgressReporter.Interfaces.Model;
using Estimating.ProgressReporter.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estimating.ProgressReporter.Interfaces.Services
{
    /// <summary>
    /// Pulls the EstimateModel and ReportModel master objects from the DataRepository and implements the comparison operations needed by the application.  
    /// Holds the public ComparatorResult object, which lists the result of the comparison.
    /// </summary>
    public interface IModelReportingService
    {
        ReportModel _reportModel { get; set; }
        EstimateModel _estimateModel { get; set; }
        IComparatorService<IModelReportingService, ReportModel, EstimateModel> _comparatorService {get; set;}
       
        //The ComparatorReport holds the final comparison results between the report and the data held in the Estimating sheet.  It holds a list 
        //of ComparatorResults, which are result profiles for each system in the report.  
        ComparatorReport ComparatorReport { get; set; } 
    }
}
