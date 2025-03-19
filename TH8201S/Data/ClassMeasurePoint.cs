using System;
namespace TH8201S.Data
{
    public class ClassMeasurePoint
    {
        public DateTime T {  get; set; }
        public double RealStrain {  get; set; }
        public double RealForce { get; set; }
        public double RealStress { get; set; }
        public double RealELong { get; set; }

        public ClassMeasurePoint Clone()
        {
            return new ClassMeasurePoint()
            {
                T = T,
                RealStrain = RealStrain,
                RealForce = RealForce,
                RealStress = RealStress,
                RealELong = RealELong
            };
        }
    }
}
