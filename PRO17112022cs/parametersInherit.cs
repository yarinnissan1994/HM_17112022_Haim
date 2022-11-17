using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRO17112022cs
{
    internal class Parent
    {
        public Parent(int id, string name)
        {

        }
        public Parent(string name)
        {

        }
        public Parent(int id)
        {

        }
    }
    class Child : Parent
    {
        public Child(int id) : base(id) { }
        public Child(int id, string name) : base(id, name) { }
        public Child() : base(123) { }
        public Child(string name) : base("kaza") { }
    }
}

