using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
   
    internal class Program
    {
        static void Main(string[] args)
        {
            People p1=new People();

            Emplyee e1=new Emplyee();
            
            People p2=new Emplyee();
            //請問p2有哪些屬性?//2個,已宣告的型別為準
            
            var obj3 = new Emplyee();
            
        }
    }
    /// <summary>
    /// 人類
    /// </summary>
    public class People
    {
        public bool Gender { get; set; }//性別
        public string SID { get; set; }//身分字號
    }
    public class Emplyee:People//繼承
    {
        public string BadgeNumber { get; set; }//員工編號
    }




}
