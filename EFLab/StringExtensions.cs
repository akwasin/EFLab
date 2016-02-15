using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFLab_3a
{
    public static class StringExtensions
    {
        public static float FloatConverter(this string value)
        {
            float outPut = float.Parse(value);

            return outPut;
        }
    }
}
