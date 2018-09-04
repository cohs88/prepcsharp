using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamRef70483.Obj1_4
{
    public class Pub
    {
        private event EventHandler<MisArgumentos> onChange = delegate { };
        /// <summary>
        /// un evento no puede ser asignado directamente (=) solo con (+=)
        /// Asi no corre riesgo de que alguien mas elimine los eventos anteriores
        /// otra cosa es que no puede ser ejecutado por usuarios externos si no por quien los define
        /// </summary>
        public event EventHandler<MisArgumentos> OnChange
        {
            add
            {
                lock (onChange)
                {
                    onChange += value;
                }
            }
            remove
            {
                lock (onChange)
                {
                    onChange -= value;
                }
            }
        }
        public void Raise()
        {
            Console.WriteLine($"Invocation list: {onChange.GetInvocationList().GetLength(0)}");
            onChange(this, new MisArgumentos(42));
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
