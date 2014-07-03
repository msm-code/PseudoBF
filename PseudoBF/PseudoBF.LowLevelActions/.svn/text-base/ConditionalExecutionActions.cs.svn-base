using System;
using PseudoBF.MachineModel;

namespace PseudoBF.Compilation.Operations
{
    public static class ConditionalExecutionActions
    {
        public static void While(this IMachine machine, Location test, Action action)
        {
            machine.MoveTo(test);
            machine.BeginConditional();
            {
                action();
                machine.MoveTo(test);
            }
            machine.EndConditional();
        }

        public static void If(this IMachine machine, Location test, Location temp0, Location temp1, Action actionIf)
        {
            /* temp0[-]
             * temp1[-]
             * x[temp0+temp1+x-]temp0[x+temp0-]
             * temp1[temp0-temp1[-]]
             * temp0[
             *   code
             *   temp0-] */

            machine.Set(temp0, 0);
            machine.Set(temp1, 0);
            machine.DecUntilZero(test, new[] { temp0, temp1 }, null);
            machine.DecUntilZero(temp0, new[] { test }, null);

            machine.While(temp1, () =>
            {
                machine.Dec(temp0);
                machine.Set(temp1, 0);
            });

            machine.While(temp0, () =>
            {
                actionIf();
                machine.Set(temp0, 0);
            });
        }

        public static void IfElse(this IMachine machine, Location test, Location temp0, Location temp1, 
            Action actionIf, Action actionElse) 
        {
            /* temp0[-]
             * temp1[-]
             * x[temp0+temp1+x-]temp0[x+temp0-]+
             * temp1[
             *   code1
             *   temp0-
             *   temp1[-]]
             * temp0[
             *   code2
             *   temp0-] */

            machine.Set(temp0, 0);
            machine.Set(temp1, 0);
            machine.DecUntilZero(test, new[] { temp0, temp1 }, null);
            machine.DecUntilZero(temp0, new[] { test }, null);
            machine.Inc(temp0);

            machine.While(temp1, () =>
            {
                actionIf();
                machine.Dec(temp0);
                machine.Set(temp1, 0);
            });
            machine.While(temp0, () =>
            {
                actionElse();
                machine.Dec(temp0);
            });
        }
    }
}
