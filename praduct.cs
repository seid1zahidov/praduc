using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    class praduct
    {
        public string  Name { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }

        public double Totoalinciom { get; set; }

        public praduct(string name) 
        {
            Name = name;
        
        }
        public void Sell() 
        {
            if (Count > 0)
            {
                Count--;
                Totoalinciom += Price;
            }
            else
            {
                Console.WriteLine("mehsul bitdi");
            }
        
        }





    }
}
