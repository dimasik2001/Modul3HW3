using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3HW3
{
    public class Class1
    {
        public event Action<bool> DelegateForShow;

        public void InvokeDelegateForShow(bool status)
        {
            DelegateForShow?.Invoke(status);
        }
    }
}
