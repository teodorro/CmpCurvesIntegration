using System.Collections.Generic;

namespace CmpCurvesIntegrationModel
{
    /// <summary>
    /// Данные для отображения
    /// </summary>
    public interface ICmpScan
    {
        List<int[]> Data { get; }
        int Length { get; }
        double StepX { get; set; }
        double StepTime { get; set; }

    }


    public class CmpScan : ICmpScan
    {
        public List<int[]> Data { get; }
        public int Length => Data.Count;
        public double StepX { get; set; }
        public double StepTime { get; set; }
    }
}