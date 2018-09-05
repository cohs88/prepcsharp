using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamRef70483.Obj2_1
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T">it must be a reference type such as class, interface, delegate or array. Type must have a public default constructor</typeparam>
    public class MiClaseGenerica<T>
        where T : class, new()
    {
        T MiPropiedad { get; set; }
        public MiClaseGenerica()
        {
            MiPropiedad = new T();
        }

        /// <summary>
        /// con default obtenes el valor por defecto del generic
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public void MiMetodoGenerico<S>()
        {
            S defaultValue = default(S);
        }
    }

    public class ClaseHija
    {
        public void DoSomething()
        {
            MiClaseGenerica<ClaseHija2> miClaseGenerica = new MiClaseGenerica<ClaseHija2>();
            miClaseGenerica.MiMetodoGenerico<ClaseHija2>();
        }
    }

    public class ClaseHija2
    {
        public ClaseHija2()
        {

        }
        public ClaseHija2(int x)
        {

        }
    }
}
