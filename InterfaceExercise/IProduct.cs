using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFaceExcercise
{
    internal interface IProduct
    {
        bool MatchesName(string value);
        double CalculateTotal();
    }
}