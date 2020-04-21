using Estimating.ProgressReporter.Model;
using Estimating.PseudoDataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estimating.ProgressReporter.Interfaces.Model
{

    /// <summary>
    /// Contains lists of ComparatorResult and EstimateModel objects; Represents the result of the comparison.
    /// </summary>
    public class ComparatorReport
    {
        private EstimateModel _estimateModel;
        private ReportModel _reportModel;

        //Holds a list of comparator results for systems that were reported on in the weekly report. 
        List<ComparatorResult> ReportedSystems;
        //If a system wasn't included in the weekly report, it will be added to a list of 'UnreportedSystems' to be included in the final report. 
        List<EstimateModel> UnreportedSystems;
        //Finished systems 
        List<ReportModel> FinishedSystems;
        //Unfinished systems
        List<EstimateModel> UnfinishedSystems;

        //CONSTRUCTOR
        public ComparatorReport(EstimateModel EstimateModel, ReportModel ReportModel)
        {
            _estimateModel = EstimateModel;
            _reportModel = ReportModel;
        }


        /// <summary>
        /// Returns a ComparatorResult object for the two provided systems or null if the comparison cannot be completed.
        /// </summary>
        /// <param name="systemEstimate"></param>
        /// <param name="systemReport"></param>
        /// <returns></returns>
        public ComparatorResult CompareBySystem(SystemEstimate systemEstimate, SystemReport systemReport)
        {
            ComparatorResult comparatorResult = new ComparatorResult() {
                SystemName = "TEST",
                IsWorkCompleted = true,
                EstimatePhaseCodes = DummyFactory.DummyPhaseCodeList(),
                FinishedPhaseCodes = DummyFactory.DummyPhaseCodeList(),
                UnfinishedPhaseCodes = DummyFactory.DummyPhaseCodeList()
            };

            if(systemEstimate.Name != systemReport.Name)
            {
                return null;
            }
            else
            {

                return comparatorResult;
            }
        }

        public List<ReportModel> GetCompletedSystems()
        {
            throw new NotImplementedException();
        }

        private List<PhaseCode> GetCompletedPhaseCodes(SystemEstimate systemEstimate, SystemReport systemReport)
        {
            throw new NotImplementedException();
        }
        private List<PhaseCode> GetUnfinishedPhaseCodes(SystemEstimate systemEstimate, SystemReport systemReport)
        {
            throw new NotImplementedException();
        }

        private double GetPercentComplete(SystemEstimate systemEstimate, SystemReport systemReport)
        {
            throw new NotImplementedException();
        }

        private bool IsSystemComplete(SystemEstimate systemEstimate, SystemReport systemReport)
        {
            throw new NotImplementedException();
        }

        public List<EstimateModel> GetUnfinishedSystems()
        {
            throw new NotImplementedException();
        }







    }
}
