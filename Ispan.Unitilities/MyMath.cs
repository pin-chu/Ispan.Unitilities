﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispan.Unitilities
{
    /// <summary>
    /// 與數學相關的輔助類別
    /// </summary>
    public class MyMath
    {
        /// <summary>
        /// 計算折扣
        /// </summary>
        /// <param name="price">原始價格</param>
        /// <param name="discount">折扣,例如八折輸入0.8</param>
        /// <returns>傳回折扣後的價格</returns>
        public int Gettotal(int price,double discount)
        {
            return (int)Math.Round(price * discount, MidpointRounding.AwayFromZero);
        }
    }//,MidpointRounding.AwayFromZero
}
