using System;
using System.Collections.Generic;
using System.Text;

namespace _18042022Task
{
    class Course
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public void ShowInfo()
        {
            Console.WriteLine($"ID:{ID}---Name:{Name}---Description:{Description}---Price:{Price}");
        }

    }
}
