using Ispan.Unitilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    internal class ParjingFeeTests
    {
       
        
        public void CalcFee_一小時_傳5元()
        {
            var obj=new ParkingFee();
            int minutes = 60;
            int expected = 5;

            int actual = obj.CalcFee(minutes);

            Assert.AreEqual(expected, actual);
        }
        [TestCase(59,5)]
        [TestCase(61,10)]
        public void CalcFee不足一小時無條件進位(int minutes, int expected)
        {
            var obj = new ParkingFee();
           

            int actual = obj.CalcFee(minutes);

            Assert.AreEqual(expected, actual);
        }
        [TestCase(360)]
        [TestCase(361)]
        public void CalcFee_每天最多收30元(int minutes)
        {
            int expected = 30;
            var obj = new ParkingFee();

            int actual=obj.CalcFee(minutes);
            Assert.AreEqual(expected, actual);
        }
    
    
    
    }
}
