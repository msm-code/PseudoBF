using System.Collections.Generic;

namespace PseudoBF.CodeDom
{
    public class ProgramModel
    {
        public ProgramModel(List<Subroutine> subroutines)
        {
            this.Subroutines = subroutines;
        }

        public List<Subroutine> Subroutines
        { get; private set; }

        public void Link()
        {
            foreach (var sub in Subroutines)
            {
                sub.LinkTo(this);
            }
        }

        internal Subroutine GetSubroutine(string procName)
        {
            return Subroutines.Find((x) => x.Name == procName);
        }
    }
}
