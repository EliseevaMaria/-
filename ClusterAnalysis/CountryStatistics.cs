using System;
using CenterSpace.NMath.Core;

namespace ClusterAnalysis
{
    public class CountryStatistics
    {
        public string Country
        {
            get;
            set;
        }

        public double MeatConsumption { get; set; }

        public double ButterConsumption { get; set; }

        public double AlcoholConsumption { get; set; }

        public double FruitConsumption { get; set; }

        public DoubleVector GetDoubleVector()
        {
            return new DoubleVector(this.MeatConsumption, this.ButterConsumption,
                                    this.AlcoholConsumption, this.FruitConsumption);
        }

        public override string ToString()
        {
            return this.Country;
        }
    }
}
