using BuilderDesignPatternEx;
using System;


public class Program
{
    public static void Main()
    {
        IComputerBuilder builder = new GamingComputerBuilder();
        ComputerDirector director = new ComputerDirector(builder);

        director.BuildComputer();
        Computer computer = builder.GetComputer();
        computer.DisplaySpecifications();
    }
}
