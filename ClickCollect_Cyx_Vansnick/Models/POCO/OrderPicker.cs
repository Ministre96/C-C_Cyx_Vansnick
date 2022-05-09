using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClickCollect_Cyx_Vansnick.Models.POCO
{
    public class OrderPicker : Employee
    {
        public OrderPicker(string u, string pw, string fn, string ln, string e, string ph) : base(u, pw, fn, ln, e, ph)
        {
        }
    }
}
