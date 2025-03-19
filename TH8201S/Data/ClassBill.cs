using System;
using System.Collections.Generic;

namespace TH8201S.Data
{
    public class ClassBill
    {
        // Bỏ qua 2 điểm gần nhau có cùng Strain
        public bool SkipDupStrain { get; set; } = true;
        private const double StrainEsp = 0.001;
        public int Id { get; set; }

        public bool IsSaved { get; set; }
        public List<ClassMeasurePoint> MeasurePoints { get; private set; } = new List<ClassMeasurePoint>();

        public double MinForce {  get; set; }
        public double MaxForce { get; set; }
        public double MaxForce_Strain {  get; set; }
        public double MinStrain {  get; set; }
        public double MaxStrain { get; set; }

        /// <summary>
        /// Reset dữ liệu trong bill<br/>
        /// Sử dụng khi tạo bill mới
        /// </summary>
        /// <param name="id"></param>
        public void Renew(int id)
        {
            Id = id;
            MeasurePoints.Clear();
            IsSaved = false;
        }

        /// <summary>
        /// Thêm điểm với điều kiện là điềm mới (T > T điểm cuối cùng đã thêm) <br/>
        /// Sử dụng hàm này thay cho việc thêm trực tiếp vào MeasurePoints
        /// </summary>
        /// <param name="point"></param>
        /// <returns>Trả về true nếu thêm điểm</returns>
        public bool AddPoint(ClassMeasurePoint point)
        {
            if (MeasurePoints.Count > 0)
            {
                var p = MeasurePoints[MeasurePoints.Count - 1];
                if (point.T > p.T)
                {
                    if (SkipDupStrain && Math.Abs(point.RealStrain - p.RealStrain) < StrainEsp) return false;
                    MeasurePoints.Add(point.Clone());
                    MinForce = Math.Min(MinForce, point.RealForce);
                    if (MaxForce < point.RealForce)
                    {
                        MaxForce = point.RealForce;
                        MaxForce_Strain = point.RealStrain;
                    }
                    MinStrain = Math.Min(MinStrain, point.RealStrain);
                    MaxStrain = Math.Max(MaxStrain, point.RealStrain);
                    return true;
                }
            }
            else
            {
                MeasurePoints.Add(point.Clone());
                MinForce = point.RealForce;
                MaxForce = point.RealForce;
                MaxForce_Strain = point.RealStrain;
                MinStrain = point.RealStrain;
                MaxStrain = point.RealStrain;
                return true;
            }
            return false;
        }
    }
}
