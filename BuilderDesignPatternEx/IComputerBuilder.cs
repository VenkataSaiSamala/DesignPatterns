using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPatternEx
{
    public interface IComputerBuilder
    {
        void SetCPU();
        void SetRAM();
        void SetHardDrive();
        void SetGraphicsCard();
        void SetSoundCard();
        Computer GetComputer();
    }
}
