using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM
{
    public class People
    {
        public string Name { get; set; }
        public int Amount { get; set; }
        public bool IsMarried { get; set; }

        public decimal Tax { get; set; }
        public void CaculateTax()
        {
            Tax = Amount / 2;
        }
    }
}
