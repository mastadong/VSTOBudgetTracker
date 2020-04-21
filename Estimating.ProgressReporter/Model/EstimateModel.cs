using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estimating.ProgressReporter.Interfaces.Model
{
    public class EstimateModel : ISystemModel
    {
        public string JobNumber { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string JobName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<object> Systems { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
