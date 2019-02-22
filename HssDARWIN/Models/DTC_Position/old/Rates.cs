using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HssUtility.General;

namespace HssDARWIN.Models.DTC_Position
{
    public class Rates
    {
        public const int RateCount = 18;
        private decimal[] rate_array = new decimal[Rates.RateCount + 1];

        public Rates()
        {
            for (int i = 0; i < this.rate_array.Length; ++i) this.rate_array[i] = 0;
        }

        public decimal this[int index]
        {
            get
            {
                if (index < 1 || index > Rates.RateCount) return 0;
                else return this.rate_array[index];
            }
            set
            {
                if (index < 1 || index > Rates.RateCount) return;
                else this.rate_array[index] = value;
            }
        }

        public void Set_rateValue(int index, string val_str)
        {
            decimal tempDec = 0;
            if (decimal.TryParse(val_str, out tempDec)) this.Set_rateValue(index, tempDec);
        }

        public void Set_rateValue(int index, decimal value)
        {
            if (index < 1 || index > Rates.RateCount) return;
            else this.rate_array[index] = value;
        }
    }
}
