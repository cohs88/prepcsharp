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
        public event Action OnChange = delegate { };
        public void Raise()
        {
            Console.WriteLine($"Invocation list: {OnChange.GetInvocationList().GetLength(0)}");
            OnChange();
        }
    }
}
