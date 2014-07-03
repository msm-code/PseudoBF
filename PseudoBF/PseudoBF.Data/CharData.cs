using PseudoBF.CodeInfrastructure;
using PseudoBF.MachineModel;

namespace PseudoBF.Data
{
    public class CharData : IInMemoryData
    {
        public const string Type = "Char";

        public void SkipForward(IMachine machine)
        {
            machine.Forward(1);
        }

        public void SkipBackward(IMachine machine)
        {
            machine.Backward(1);
        }

        public string DataType
        {
            get { return CharData.Type; }
        }
    }
}
