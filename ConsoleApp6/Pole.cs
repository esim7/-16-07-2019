using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Pole
    {
        private string _typeCroops;
        
        public Pole()
        {
            _typeCroops = " ";
        }
        public string GetTypeCroops()
        {
            return _typeCroops;
        }
        public void SetTypeCroops(string typeCroops)
        {
            _typeCroops = typeCroops;
        }
    }
}
