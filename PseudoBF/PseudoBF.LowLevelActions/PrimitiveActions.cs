using PseudoBF.MachineModel;
using System.Collections.Generic;

namespace PseudoBF.Compilation.Operations
{
    public static class PrimitiveActions
    {
        public static void MoveTo(this IMachine machine, Location destination)
        {
            Location machineLoc = machine.Location;
            int offset = Location.Offset(machineLoc, destination);

            if (offset > 0)
            {
                machine.Forward(offset);
            }
            else
            {
                machine.Backward(-offset);
            }
        }

        public static void Copy(this IMachine machine, Location destination, Location source, Location helper)
        {
            /* // x = y
             * hlp[-]
             * dst[-]
             * src[dest+hlp+src-]
             * hlp[src+hlp-] */

            machine.Set(helper, 0);
            machine.Set(destination, 0);

            machine.DecUntilZero(source, new[] { destination, helper }, null);
            machine.DecUntilZero(helper, new[] { source }, null);
        }

        public static void Set(this IMachine machine, Location destination, byte value)
        {
            machine.While(destination, () =>
            {
                machine.Dec(1);
            });

            for (int i = 0; i < value; i++)
            {
                machine.Inc(1);
            }
        }

        public static void Inc(this IMachine machine, Location loc)
        {
            machine.MoveTo(loc);
            machine.Inc(1);
        }

        public static void Inc(this IMachine machine, Location loc, byte howMuch)
        {
            machine.MoveTo(loc);
            machine.Inc(howMuch);
        }

        public static void Dec(this IMachine machine, Location loc)
        {
            machine.MoveTo(loc);
            machine.Dec(1);
        }

        public static void Dec(this IMachine machine, Location loc, byte howMuch)
        {
            machine.MoveTo(loc);
            machine.Dec(howMuch);
        }

        public static void DecUntilZero(this IMachine machine, Location decMeUntilZero,
            IEnumerable<Location> incMe, IEnumerable<Location> decMe)
        {
            machine.While(decMeUntilZero, () =>
            {
                if (incMe != null) { foreach (Location loc in incMe) { machine.Inc(loc); } }
                if (decMe != null) { foreach (Location loc in decMe) { machine.Dec(loc); } }
                machine.Dec(decMeUntilZero);
            });
        }
    }
}
