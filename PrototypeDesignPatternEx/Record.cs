using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDesignPatternEx
{
    public class Record : IRecordPrototype
    {
        public int Id { get; set; }
        public string Data { get; set; }

        public IRecordPrototype Clone()
        {
            return new Record { Id = Id, Data = Data };
        }

        public override string ToString()
        {
            return $"ID: {Id} | Data: {Data}";
        }
    }
}
