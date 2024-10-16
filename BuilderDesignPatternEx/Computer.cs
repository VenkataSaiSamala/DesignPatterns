﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPatternEx
{
    public class Computer
    {
        public string CPU { get; set; }
        public string RAM { get; set; }
        public string HardDrive { get; set; }
        public string GraphicsCard { get; set; }
        public string SoundCard { get; set; }

        public void DisplaySpecifications()
        {
            Console.WriteLine($"CPU: {CPU}");
            Console.WriteLine($"RAM: {RAM}");
            Console.WriteLine($"Hard Drive: {HardDrive}");
            Console.WriteLine($"Graphics Card: {GraphicsCard ?? "Not present"}");
            Console.WriteLine($"Sound Card: {SoundCard ?? "Not present"}");
        }
    }
}
