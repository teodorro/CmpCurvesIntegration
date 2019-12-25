using System.Collections.Generic;
using System.Linq;

namespace CmpCurvesIntegrationModel
{
    /// <summary>
    /// Данные для отображения
    /// </summary>
    public interface ICmpScan
    {
        List<int[]> Data { get; }
        double StepX { get; set; }
        double StepTime { get; set; }
        int LengthDimensionless { get; }
        double Length { get; }
        int AscanLengthDimensionless { get; }
        double AscanLength { get; }
    }


    public class CmpScan : ICmpScan
    {
        public List<int[]> Data { get; } = new List<int[]>();
        public double StepX { get; set; } = 0.1;
        public double StepTime { get; set; } = 1;
        public int LengthDimensionless => Data.Count;
        public double Length => Data.Count * StepX;
        public int AscanLengthDimensionless => Data.Any() ? Data.Select(x => x.Length).Min() : -1;
        public double AscanLength => AscanLengthDimensionless * StepTime;
    }
}