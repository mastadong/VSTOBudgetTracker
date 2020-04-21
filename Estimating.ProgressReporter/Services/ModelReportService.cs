using Estimating.ProgressReporter.Interfaces.Model;
using Estimating.ProgressReporter.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Estimating.ProgressReporter.Services
{
    public class ModelReportService : IModelReportingService
    {
        public EstimateModel _estimateModel { get; set; }
        public ReportModel _reportModel { get; set; }
        private IComparatorService _comparatorService { get; set; }
       
        //CONSTRUCTOR
        public ModelReportService(EstimateModel estimateModel, ReportModel reportModel, IComparatorService comparatorService)
        {
            _reportModel = reportModel;
            _estimateModel = estimateModel;
            _comparatorService = comparatorService;
        }

        /// <summary>
        /// Returns the completed report object or a NULL value if the report cannot be completed.
        /// </summary>
        /// <returns></returns>
        public ComparatorReport GetModelReport()
        {
            try
            {
                return _comparatorService.Compare(_estimateModel, _reportModel);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
}
