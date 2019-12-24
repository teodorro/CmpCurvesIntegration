using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CmpCurvesIntegrationModel.Processing
{
    public interface IRawDataProcessor
    {
        void AutoDetectProcessingsToUse(CmpScan data);
        ObservableCollection<IRawDataProcessing> Operations { get; }
    }

    public interface IRawDataProcessing
    {
        void Process(ICmpScan data);
    }

    
    public class RawDataProcessor : IRawDataProcessor
    {
        public ObservableCollection<IRawDataProcessing> Operations { get; }

        public void AutoDetectProcessingsToUse(CmpScan data)
        {

        }
    }
}