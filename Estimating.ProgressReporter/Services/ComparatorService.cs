using Estimating.ProgressReporter.Core;
using Estimating.ProgressReporter.Interfaces.Model;
using Estimating.ProgressReporter.Interfaces.Services;
using Estimating.ProgressReporter.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Estimating.ProgressReporter.Services
{
    /// <summary>
    /// Manages the ComparatorModel class that holds the key applciation data.
    /// </summary>
    public class ComparatorService : IComparatorService
    {
        public ReportModel _reportModel { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public EstimateModel _estimateModel { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IModelReportingService _modelReportingService { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }


        public ComparatorReport Compare(EstimateModel estimateModel, ReportModel reportModel)
        {
            throw new NotImplementedException();
        }
    }
}
