using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumVectors.classes
{
    public class DataAdapter
    {
        private const string InvalidArgumentsMessage = "Vector Arguments are not valid, the correct Format is x1,y2 x2,y2";
        private const string InvalidNumberMessage = "Vector Arguments must supply valid numbers.";
        public Vector VectorA { get; private set; }
        public Vector VectorB { get; private set; }

        public DataAdapter(string[] args)
        {
            if (args.Length == 2)
            {
                var argumentsA = args[0].Split(',');
                var argumentsB = args[1].Split(',');

                this.VectorA = new Vector(TryGetInteger(argumentsA[0]), TryGetInteger(argumentsA[1]));
                this.VectorB = new Vector(TryGetInteger(argumentsB[0]), TryGetInteger(argumentsB[1]));

            }
            else
            {
                throw new ArgumentException(InvalidArgumentsMessage);
            }
        }
        private int TryGetInteger(string value)
        {
            if (!int.TryParse(value, out var parsedValue))
            {
                throw new ArgumentException(InvalidNumberMessage);
            }
            return parsedValue;
        }
    }
}
