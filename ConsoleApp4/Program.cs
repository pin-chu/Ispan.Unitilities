﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var member = new Member("hsu");
        }
    }
    public class Member 
    {
        private string name;

        public Member(string name)
        {
            this.name = name;
        }
    }
}
