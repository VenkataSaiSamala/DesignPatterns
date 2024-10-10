using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPatternEx
{
    public class ComputerDirector
    {
        private readonly IComputerBuilder _builder;

        public ComputerDirector(IComputerBuilder builder)
        {
            _builder = builder;
        }

        public void BuildComputer()
        {
            _builder.SetCPU();
            _builder.SetRAM();
            _builder.SetHardDrive();
            _builder.SetGraphicsCard();
            _builder.SetSoundCard();
        }
    }
}
