namespace PseudoBF.MachineModel
{
    public interface IMachine
    {
        Location Location { get; }
        void Comment(string format, params object[] args);
        void Forward(int howMuch);
        void Backward(int howMuch);
        void Inc(int howMuch);
        void Dec(int howMuch);
        void Read();
        void Print();
        void BeginConditional();
        void EndConditional();
    }
}
