using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumVectors
{
    class Program
    {
        static void Main(string[] args)
        {
            var adapter = new classes.DataAdapter(args);
            var vectorA = adapter.VectorA;
            var vectorB = adapter.VectorB;
            var vectorSumResultDisplay = vectorA.Add(vectorB);
            var vectorProdResultDisplay = vectorA.Prop(vectorB);
            var vectorLength = vectorSumResultDisplay.Length();
            Console.WriteLine($"Sum: {vectorSumResultDisplay.ToString()}");
            Console.WriteLine($"Prod: {vectorProdResultDisplay}");
            Console.WriteLine($"length: {vectorLength}");
        }
    }
}
