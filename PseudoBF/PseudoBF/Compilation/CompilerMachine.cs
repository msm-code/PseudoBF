using System.Text;
using System;
using PseudoBF.MachineModel;

namespace PseudoBF.Compilation
{
    public class CompilerMachine : IMachine
    {
        StringBuilder builder;
        int location;

        public CompilerMachine()
        {
            builder = new StringBuilder();
        }

        public Location Location
        {
            get { return new Location(location); }
            set { location = value.InternalPosition; }
        }

        public void Backward(int times)
        {
            builder.Append(new string('<', times));

            location -= times;
            if (location < 0)
            { throw new System.InvalidOperationException("Offset is lesset than 0"); }
        }

        public void Forward(int times)
        {
            builder.Append(new string('>', times));

            location += times;
        }

        public void Inc(int howMuch)
        {
            builder.Append(new string('+', howMuch));
        }

        public void Dec(int howMuch)
        {
            builder.Append(new String('-', howMuch));
        }

        public void Read()
        {
            builder.Append(",");
        }

        public void Print()
        {
            builder.Append(".");
        }

        public void BeginConditional()
        {
            builder.Append("[");
        }

        public void EndConditional()
        {
            builder.Append("]");
        }

        public string CompiledCode 
        { get { return builder.ToString(); } }

        public void Reset()
        {
            this.location = 0;
            builder = new StringBuilder();
        }

        public void Comment(string format, params object[] args)
        {
            bool clear = builder.Length == 0 || builder[builder.Length - 1] == '\n';
            string msg = (clear ? "" : "\n") + string.Format(format, args) + "\n";
            string finalMsg = msg.Replace("[", "{").Replace("]", "}")
                                 .Replace("+", "#p").Replace("-", "#m")
                                 .Replace(".", "#").Replace(",", ";")
                                 .Replace("<", "(lt)").Replace(">", "(gt)");
            builder.Append(finalMsg);
        }

        public void OverrideLocation(Location newLoc)
        {
            this.location = newLoc.InternalPosition;
        }
    }
}
