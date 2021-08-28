using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicalFunctionsLibrary;



namespace LogicalFunctionsCalculator.Classes
{

    //
    // НЕ СОВСЕМ ООП. НЕ ДЕЛАЙТЕ ТАК
    //

    class LogicalCalculator : LogicalFunctionsCalculator.Modules.ILogicalCalculator
    {
        
        private bool A;
        private bool B;

        public void Get_A(bool arg)
        {
            A = arg;
        }

        public void Get_B(bool arg)
        {
            B = arg;
        }

        public bool Denial()
        {
            return LogicalFunctions.Denial(A);
        }

        public bool Conjunction()
        {
            return LogicalFunctions.Conjunction(A, B);
        }

        public bool Disjunction()
        {
            return LogicalFunctions.Disjunction(A, B);
        }

        public bool ExclusiveOr()
        {
            return LogicalFunctions.ExclusiveOr(A, B);
        }

        public bool Implication()
        {
            return LogicalFunctions.Implication(A, B);
        }
        public bool Equivalence()
        {
            return LogicalFunctions.Equivalence(A, B);
        }
        public bool SchaeffersStroke()
        {
            return LogicalFunctions.SchaeffersStroke(A, B);
        }

        public bool PeircesArrow()
        {
            return LogicalFunctions.PeircesArrow(A, B);
        }

    }
}
