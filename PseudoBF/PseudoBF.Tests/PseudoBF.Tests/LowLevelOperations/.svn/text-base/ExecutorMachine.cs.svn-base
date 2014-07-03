using PseudoBF.MachineModel;
using PseudoBF.Compilation;
using Brainfuck;

namespace PseudoBF.Tests.LowLevelOperations
{
    class ExecutorMachine : IMachine
    {
        CompilerMachine underlying;
        BrainfuckMachine executor;

        public ExecutorMachine()
        {
            underlying = new CompilerMachine();
            this.executor = new BrainfuckMachine();
        }

        public void Execute()
        {
            executor.Execute(underlying.CompiledCode);
            underlying.Reset();
        }

        #region BrainfuckMachine Wrappers
        public byte GetCell(int ndx)
        { return executor.GetCell(ndx); }

        public void SetCell(int ndx, byte value)
        { executor.SetCell(ndx, value); }

        public byte[] GetCurrentState()
        { return executor.GetCurrentState(); }

        public int HeadLocation
        { get { return executor.HeadLocation; } }
        #endregion

        #region CompilerMachine Wrappers
        public Location Location
        { get { return underlying.Location; } }

        public void Forward(int howMuch)
        { underlying.Forward(howMuch); }

        public void Backward(int howMuch)
        { underlying.Backward(howMuch); }

        public void Inc(int howMuch)
        { underlying.Inc(howMuch); }

        public void Dec(int howMuch)
        { underlying.Dec(howMuch); }

        public void Read()
        { underlying.Read(); }

        public void Print()
        { underlying.Print(); }

        public void BeginConditional()
        { underlying.BeginConditional(); }

        public void EndConditional()
        { underlying.EndConditional(); }
        #endregion
    }
}
