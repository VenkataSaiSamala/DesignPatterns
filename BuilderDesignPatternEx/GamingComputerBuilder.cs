using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPatternEx
{
    public class GamingComputerBuilder : IComputerBuilder
    {
        private Computer _computer = new Computer();

        public void SetCPU()
        {
            _computer.CPU = "High Performance CPU";
        }

        public void SetRAM()
        {
            _computer.RAM = "16 GB DDR4";
        }

        public void SetHardDrive()
        {
            _computer.HardDrive = "1 TB SSD";
        }

        public void SetGraphicsCard()
        {
            _computer.GraphicsCard = "High-end Graphics Card";
        }

        public void SetSoundCard()
        {
            _computer.SoundCard = "7.1 Surround Sound Card";
        }

        public Computer GetComputer()
        {
            return _computer;
        }
    }

}
