using System;

namespace TH8201S.Data
{
    public class TensileFeatures
    {
        public double StrainMin {  get; set; }
        public double StrainMax { get; set; }
        public double ForceMin { get; set; }        
        public double ForceMax { get; set; }
        public double ForceMaxStrain { get; set; }

        public void Reset()
        {
            StrainMin = double.MaxValue;
            StrainMax = double.MinValue;
            ForceMin = double.MaxValue;
            ForceMax = double.MinValue;
        }

        public void Check(double strain, double force)
        {
            StrainMin = Math.Min(StrainMin, strain);
            StrainMax = Math.Max(StrainMax, strain);
            ForceMin = Math.Min(ForceMin, force);
            if (ForceMax < force)
            {
                ForceMax = force;
                ForceMaxStrain = strain;
            }
        }
    }
}
