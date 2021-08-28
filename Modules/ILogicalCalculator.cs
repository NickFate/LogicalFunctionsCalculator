using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalFunctionsCalculator.Modules
{
    interface ILogicalCalculator
    {
        void Get_A(bool arg);

        void Get_B(bool arg);

        bool Denial();

        bool Conjunction();

        bool Disjunction();

        bool ExclusiveOr();

        bool Implication();

        bool Equivalence();

        bool SchaeffersStroke();

        bool PeircesArrow();

    }
}
