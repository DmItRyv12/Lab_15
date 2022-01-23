using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    interface IMovable
    {
        void Move();
        void Brake();
    
    }
    class Mercedes : IMovable
    {
        public void Brake()
        {
            throw new NotImplementedException();
        }

        public void Move()
        {
            throw new NotImplementedException();
        }
    }
}
