

using PrototypeDesignPatternEx;

public class Program
{
    public static void Main()
    {
        Record prototypeRecord = new Record { Id = 1, Data = "Original Data" };
        Console.WriteLine("Original Record:");
        Console.WriteLine(prototypeRecord);

        Record clonedRecord = (Record)prototypeRecord.Clone();
        clonedRecord.Id = 2;
        clonedRecord.Data = "Cloned Data";
        Console.WriteLine("\nCloned and Modified Record:");
        Console.WriteLine(clonedRecord);
    }
}
