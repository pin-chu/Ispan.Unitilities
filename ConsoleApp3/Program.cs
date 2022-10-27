using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Member member=new Member("alice");
            Member member2 = new Member();
            Member member3 = new Member("alice","alice@gmail.com");
            Member member4 = new Member(18, "alice");//叫用Member 建構函數
            member.Create();//叫用Create method
        }
    }
    public class Member
    {//多載(over loading),同名稱,但不同參數
        public  Member ()
        {

        }
        public Member (string Name )
        {

        }
        public Member(string Name,string email)
        {

        }
        public Member(int age, string Name)
        {

        }
        public void Create ()
        {
            
        }
        public string Name { get; set; }
        public string email { get; set; }
    }
}
