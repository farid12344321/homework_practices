﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting_Homework_Practices.Models
{
    public class Animal
    {
        public string Name { get; set; }

        //public Animal()
        //{
        //    Console.WriteLine("Animal constructor");
        //}

        public void Test()
        {
            Console.WriteLine("Animal test");
        }

        public virtual void Sound()
        {
            Console.WriteLine("Animal sound");
        }
    }
}
