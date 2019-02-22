using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HssUtility.General
{
    public enum RelationalOperator
    {
        None = 0,

        Equals = 1,
        NotEqual = 2,

        GreaterThan = 3,
        LessThan = 4,
        Greater_or_Equals = 5,
        Less_or_Equals = 6,
    }

    public enum ConditionalOperator
    {
        And = 1,
        Or = 2,
    }    
}
