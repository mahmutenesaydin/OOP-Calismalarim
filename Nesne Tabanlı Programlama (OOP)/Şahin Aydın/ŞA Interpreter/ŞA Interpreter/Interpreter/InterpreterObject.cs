using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ŞA_Interpreter
{
   public class Context
    {
        public string Input { get; set; }
        public int Output { get; set; }
    }
    public abstract class Expression
    {
        public abstract string One();
        public abstract string Four();
        public abstract string Five();
        public abstract string Nine();
        public abstract int Multiplier();
        public void Interpret(Context context)
        {
            if (context.Input.Length == 0)
                return;
            if (context.Input.StartsWith(Nine()))
            {
                context.Output += (9 * Multiplier());
                context.Input = context.Input.Substring(2);
            }
            else if (context.Input.StartsWith(Four()))
            {
                context.Output += (4 * Multiplier());
                context.Input = context.Input.Substring(2);
            }
            else if (context.Input.StartsWith(Five()))
            {
                context.Output += (5 * Multiplier());
                context.Input = context.Input.Substring(1);
            }
            while (context.Input.StartsWith(One()))
            {
                context.Output += (1 * Multiplier());
                context.Input = context.Input.Substring(1);
            }
        }
        public class ThousandExpression : Expression
        {
            public override string Five()
            {
                return " ";
            }

            public override string Four()
            {
                return " ";
            }

            public override int Multiplier()
            {
                return 1000;
            }

            public override string Nine()
            {
                return " ";
            }

            public override string One()
            {
                return "M";
            }
        }
        public class HundradExpression : Expression
        {
            public override string Five()
            {
                return "D";
            }

            public override string Four()
            {
                return "CD";
            }

            public override int Multiplier()
            {
                return 100;
            }

            public override string Nine()
            {
                return "CM";
            }

            public override string One()
            {
                return "C";
            }
        }
        public class TenExpression : Expression
        {
            public override string Five()
            {
                return "L";
            }

            public override string Four()
            {
                return "XL";
            }

            public override int Multiplier()
            {
                return 10;
            }

            public override string Nine()
            {
                return "XC";
            }

            public override string One()
            {
                return "X";
            }
        }
        public class OneExpression : Expression
        {
            public override string Five()
            {
                return "V";
            }

            public override string Four()
            {
                return "IV";
            }

            public override int Multiplier()
            {
                return 1;
            }

            public override string Nine()
            {
                return "IX";
            }

            public override string One()
            {
                return "I";
            }
        }
    }
}
