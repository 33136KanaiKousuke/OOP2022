using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter {
    //フィートとメールの単位変換
    public class FeetConverter {
        
        //メートルからフィートを求める
        public double ToMeter(double meter) {
            return meter / 0.3048;
        }

        //フィートからメートルを求める
        public double FromMeter(double feet) {
            return feet * 0.3048;
        }
    }
}
