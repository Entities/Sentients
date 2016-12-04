using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class Enumerations
    {
        public enum TestEnum
        {
            [Description("Description 1")]
            Enum1 = 1,
            [Description("Description 2")]
            Enum2 = 2
        }
    }
}
