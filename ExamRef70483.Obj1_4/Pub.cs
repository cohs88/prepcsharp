using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamRef70483.Obj1_4
{
    public class Pub
    {
        /// <summary>
        /// un evento no puede ser asignado directamente (=) solo con (+=)
        /// Asi no corre riesgo de que alguien mas elimine los eventos anteriores
        /// otra cosa es que no puede ser ejecutado por usuarios externos si no por quien los define
        /// </summary>
        public event EventHandler OnChange = delegate { };

        public void Raise()
        {
            Console.WriteLine($"Invocation list: {OnChange.GetInvocationList().GetLength(0)}");
            //OnChange(this, EventArgs.Empty);

            var exceptions = new List<Exception>();

            foreach (Delegate handler in OnChange.GetInvocationList())
            {
                try
                {
                    handler.DynamicInvoke(this, EventArgs.Empty);
                }
                catch (Exception ex)
                {
                    exceptions.Add(ex);
                }
            }

            if (exceptions.Any())
            {
                throw new AggregateException(exceptions);
            }
        }
    }

    public class MisArgumentos : EventArgs
    {
        public int Value { get; set; }
        public MisArgumentos(int value)
        {
            Value = value;
        }
    }
}
