using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    public static class InchConverter {
        private const double ratio = 0.0254;//定数ratioを定義

        //メートルからインチを求める(静的メソッド)
        public static double ToMeter(double meter) {
            return meter / ratio;
        }

        //インチからメートルを求める(静的メソッド)
        public static double FromMeter(int inch) {
              return inch * ratio;
        }

    }
}
