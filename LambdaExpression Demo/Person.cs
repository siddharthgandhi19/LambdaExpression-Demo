﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression_Demo
{
    public class Person
    {
        public string SSN;
        public string Name;
        public string Address;
        public int Age;
        
      public Person (string ssn, string name, string addr, int age)
      {
            SSN = ssn;
            Name = name;
            Address = addr;
            Age = age;
      }
    }
}
