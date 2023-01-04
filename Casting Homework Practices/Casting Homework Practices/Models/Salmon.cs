using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting_Homework_Practices.Models
{
    internal class Salmon : Fish
    {
        public string Color { get; set; }

        //public Salmon()
        //{
        //    Console.WriteLine("Salmon canstructor");
        //}
        public override void Sound()
        {
            Console.WriteLine("Salmon sound");
        }
    }
}
