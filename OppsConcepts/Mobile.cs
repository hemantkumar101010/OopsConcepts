using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    internal class Mobile
    {
        string modelName = "iPhone";
        int price = 12000;
        public void displayModel()
        {
            Console.WriteLine("Your model name is "+ modelName +" & price is "+price);

        }
    }
}
