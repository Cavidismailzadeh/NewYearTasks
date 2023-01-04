using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.Models
{
    internal class Animal
    {
        public string Name { get; set; }
        //public Animal()
        //{
        //    Console.WriteLine("Animal Constructor");
        //}
        public virtual void Sound()
        {
            Console.WriteLine("Animal Sound");
        }
    }
}
