using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamRef70483.Obj2_1
{
    class ClaseBase
    {
        /// <summary>
        /// Le puedes hacer override por que es virtual
        /// </summary>
        /// <returns></returns>
        public virtual int MyMethod_Overridable()
        {
            return 42;
        }

        public int MyMethod_NotVirtual()
        {
            return 42;
        }
    }

    class ClaseDerivada2 : ClaseBase
    {
        public sealed override int MyMethod_Overridable()
        {
            return base.MyMethod_Overridable();
        }
    }

    class ClaseDerivada : ClaseBase 
    {
        public override int MyMethod_Overridable()
        {
            return base.MyMethod_Overridable();
        }

        public int MyMethod_NotVirtual_From_ClaseDerivada()
        {
            return base.MyMethod_NotVirtual();
        }
    }
}
